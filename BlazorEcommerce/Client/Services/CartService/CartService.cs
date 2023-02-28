using BlazorEcommerce.Shared;
using Blazored.LocalStorage;

namespace BlazorEcommerce.Client.Services.CartService
{

    public class CartService : ICartService
    {
        //ILocalStorageService pozwoli nam wykorzystywać pamięć lokalną przeglądarki (część biblioteki Blazored)

        private readonly ILocalStorageService _localStorage;
        private readonly HttpClient _http;

        public CartService(ILocalStorageService localStorage, HttpClient http)
        {
            _localStorage = localStorage;
            _http = http;
        }
     

        public event Action OnChange;

        public async Task AddToCart(CartItem cartItem)
        {
            //pobieramy zawartość koszyka z LocalStorage
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            var sameitem = cart.Find(x => x.ProductId == cartItem.ProductId && x.ProductTypeId == cartItem.ProductTypeId);

            if (sameitem == null)
            {
                cart.Add(cartItem);
            }
            else
            {
                sameitem.Quantity += cartItem.Quantity;
            }
            

            await _localStorage.SetItemAsync("cart", cart);
            //Wywołanie OnChange
            OnChange.Invoke();
        }

        //pozyskiwanie lub tworzenie koszyka
        public async Task<List<CartItem>> GetCartItems()
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }
            return cart;
        }

        //pozyskiwanie i zwracanie informacji o produktach w koszyku
        public async Task<List<CartProductResponse>> GetCartProducts()
        {
            var cartItems = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            var response = await _http.PostAsJsonAsync("api/cart/products", cartItems);
            var cartProducts = await response.Content.ReadFromJsonAsync<ServiceResponse<List<CartProductResponse>>>();
            return cartProducts.Data;
        }

        //usuwanie produktu z koszyka
        public async Task RemoveProductFromCart(int productId, int productTypeId)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if(cart == null)
            {
                return;
            }

            var cartItem = cart.Find(x => x.ProductId == productId && x.ProductTypeId == productTypeId);    

            //Usuwanie i aktualizacja koszyka
            if(cartItem != null)
            {
                cart.Remove(cartItem);
                await _localStorage.SetItemAsync("cart", cart);
                OnChange.Invoke();
            }


        }

        public async Task UpdateQuantity(CartProductResponse product)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                return;
            }

            var cartItem = cart.Find(x => x.ProductId == product.ProductId && x.ProductTypeId == product.ProductTypeId);

            //Usuwanie i aktualizacja koszyka
            if (cartItem != null)
            {
                cartItem.Quantity = product.Quantity;   
                await _localStorage.SetItemAsync("cart", cart);
            }
        }
    }
}

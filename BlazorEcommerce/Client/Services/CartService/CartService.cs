using BlazorEcommerce.Shared;
using Blazored.LocalStorage;

namespace BlazorEcommerce.Client.Services.CartService
{
    //Tworzenie koszyka

    public class CartService : ICartService
    {
        //ILocalStorageService pozwoli nam wykorzystywać pamięć lokalną przeglądarki (część biblioteki Blazored)

        private readonly ILocalStorageService _localStorage;

        public CartService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
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
            cart.Add(cartItem);

            await _localStorage.SetItemAsync("cart", cart);

            //Wywołanie OnChange
            OnChange.Invoke();
        }

        public async Task<List<CartItem>> GetCartItems()
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }
            return cart;
        }
    }
}

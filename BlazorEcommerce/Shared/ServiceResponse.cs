using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcommerce.Shared
{
    public class ServiceResponse<T>
    {
        //Serwis odpowiadający za przekazanie użytkownikowi np czy wykonana przez niego akcja zakończyła się sukcesem
        public T? Data { get; set; }
        public bool Success { get; set; } = true;   
        public string Message { get; set; } = string.Empty;
    }
}

﻿
namespace BasketApi.Exceptions
{
    public class BasketNotFoundException : NotFoundException
    {
        public BasketNotFoundException(string UserName) : base("Basket", UserName) 
        { 

        }
    }
}
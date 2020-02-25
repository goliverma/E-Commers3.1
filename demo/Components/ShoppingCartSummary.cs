using System.Collections.Generic;
using demo.Models.Data;
using demo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace demo.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            this.shoppingCart=shoppingCart;
        }
        public IViewComponentResult Invoke()
        {
            var items = shoppingCart.GetShoppingCartItems();
            shoppingCart.ShoppingCartItems=items;
            var cart=new ShoppingCartViewModel{
                ShoppingCart=shoppingCart,
                ShoppingCartTotal=shoppingCart.GetShoppingCartTotal()
            };
            return View(cart);
        }
    }
}
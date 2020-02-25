using System.Linq;
using demo.Models.Data;
using demo.Models.Interfaces;
using demo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IDrinkRepository drinkRepository;
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartController(IDrinkRepository drinkRepository, ShoppingCart shoppingCart)
        {
            this.drinkRepository=drinkRepository;
            this.shoppingCart=shoppingCart;
        }
        public IActionResult Index()
        {
            var items=shoppingCart.GetShoppingCartItems();
            shoppingCart.ShoppingCartItems = items;
            var viewmodel=new ShoppingCartViewModel{
                ShoppingCart=shoppingCart,
                ShoppingCartTotal=shoppingCart.GetShoppingCartTotal()
            };
            return View(viewmodel);
        }

        public IActionResult AddToShoppingCart(int drinkId)
        {
            var selectedDrink=drinkRepository.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
            if (selectedDrink!=null)
            {
                shoppingCart.AddToCart(selectedDrink, 1);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromShoppingCart(int drinkId)
        {
            var selectedDrink=drinkRepository.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
            if (selectedDrink!=null)
            {
                shoppingCart.RemoveFromCart(selectedDrink);
            }
            return RedirectToAction("Index");
        }
    }
}
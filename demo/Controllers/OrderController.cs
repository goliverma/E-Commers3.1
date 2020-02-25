using demo.Models.Data;
using demo.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class OrderController : Controller
    {
        private readonly ShoppingCart shoppingCart;
        private readonly IOrderRepository orderRepository;

        public OrderController(ShoppingCart shoppingCart, IOrderRepository orderRepository)
        {
            this.shoppingCart=shoppingCart;
            this.orderRepository=orderRepository;
        }
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = shoppingCart.GetShoppingCartItems();
            shoppingCart.ShoppingCartItems = items;
            if (shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your card is empty, add some drinks first");
            }

            if (ModelState.IsValid)
            {
                orderRepository.CreateOrder(order);
                shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }
        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage="Thanks for u order! :-)";
            return View();
        }
    }
}
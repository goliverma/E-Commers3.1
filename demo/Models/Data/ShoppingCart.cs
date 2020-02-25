using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace demo.Models.Data
{
    public class ShoppingCart
    {
        private readonly AppDbContext appDbContext;

        public ShoppingCart(AppDbContext appDbContext)
        {
            this.appDbContext=appDbContext;
        }
        public string ShoppingCartId{get; set;}
        public List<ShoppingCartItem> ShoppingCartItems{get; set;}

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Drink drink, int amount)
        {
            var shoppingCartItem =
                    appDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Drink.DrinkId == drink.DrinkId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Drink = drink,
                    Amount = 1
                };

                appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Drink drink)
        {
            var shoppingCartItem =
                    appDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Drink.DrinkId == drink.DrinkId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            appDbContext.SaveChanges();

            return localAmount;
        }
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                   (ShoppingCartItems =
                       appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Include(s => s.Drink)
                           .ToList());
        }

        public void ClearCart()
        {
            var cartItems = appDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            appDbContext.ShoppingCartItems.RemoveRange(cartItems);

            appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            if(ShoppingCartId==null)
            {

                return appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Drink.Price * c.Amount).Sum();
            }
            else
            {
                var total=0;
                return total ;
            }
        }


    }
}
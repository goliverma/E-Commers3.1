using System;
using demo.Models.Data;
using demo.Models.Interfaces;

namespace demo.Models.Repositorys
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext appDbContext;
        private readonly ShoppingCart shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            this.appDbContext=appDbContext;
            this.shoppingCart=shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced=DateTime.Now;
            appDbContext.Orders.Add(order);
            var shoppingCartItems=shoppingCart.ShoppingCartItems;
            foreach(var item in shoppingCartItems)
            {
                var orderdetail=new OrderDetail()
                {
                    Amount=item.Amount,
                    DrinkId=item.Drink.DrinkId,
                    OrderId=order.OrderId,
                    Price=item.Drink.Price
                };
                appDbContext.OrderDetails.Add(orderdetail);
            }
            appDbContext.SaveChanges();
        }
    }
}
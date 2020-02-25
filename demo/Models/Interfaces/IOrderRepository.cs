using demo.Models.Data;

namespace demo.Models.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
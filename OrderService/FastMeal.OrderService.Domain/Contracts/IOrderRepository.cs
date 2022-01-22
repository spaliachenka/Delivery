using FastMeal.OrderService.Domain.Models;

namespace FastMeal.OrderService.Domain.Contracts
{
    public interface IOrderRepository
    {
        Order Find(long id);

        long Save(Order order);
    }
}

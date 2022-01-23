using FastMeal.OrderService.Domain.Contracts;
using FastMeal.OrderService.Domain.Models.DTO;

namespace FastMeal.OrderService.Domain.Models
{
    public class OrderService
    {
        private readonly IOrderRepository orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public Order CreateOrder(OrderDetails orderDetails)
        {
            var order = Order.CreateOrder(orderDetails);
            orderRepository.Save(order);

            return order;
        }

        public void ApproveOrder(long orderId)
        {
            var order = orderRepository.Find(orderId);

            order.ChangeOrderStatus(Enums.OrderStatus.Approved);
        }

        public void CancelOrder(long orderId)
        {
            throw new NotImplementedException();
        }

        public void RejectOrder(long orderId)
        {
            var order = orderRepository.Find(orderId);

            order.ChangeOrderStatus(Enums.OrderStatus.Rejected);
        }
    }
}

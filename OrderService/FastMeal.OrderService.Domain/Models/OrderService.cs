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

        public long CreateOrder(OrderDetails orderDetails)
        {
            var order = Order.CreateOrder(orderDetails);
            var id = orderRepository.Save(order);

        }

        public void ApproveOrder(long orderId)
        {
            var order = orderRepository.Find(orderId);

            order.ChangeOrderStatus(Enums.OrderStatus.Approved);
        }

        public void CancelOrder(long orderId)
        {

        }

        public void RejectOrder(long orderId)
        {
            var order = orderRepository.Find(orderId);

            order.ChangeOrderStatus(Enums.OrderStatus.Rejected);
        }
    }
}

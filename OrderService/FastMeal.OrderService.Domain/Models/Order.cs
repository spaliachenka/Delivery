using FastMeal.OrderService.Domain.Models.DTO;
using FastMeal.OrderService.Domain.Models.Enums;

namespace FastMeal.OrderService.Domain.Models
{
    public class Order
    {
        public long OrderId { get; init; }

        public int ConsumerId { get; init; }

        public int RestaurantId { get; init; }

        public DateTime? CreateDate { get; init; }

        public OrderStatus Status { get; private set; }

        public IReadOnlyList<OrderListItem> OrderListItems => _orderListItems;

        private List<OrderListItem> _orderListItems { get; init; } = new List<OrderListItem>();

        public decimal Total => OrderListItems.Sum(x=>x.Price * x.Quantity);

        private Order(long orderId, int consumerId, int restaurantId, DateTime? createDate)
        {
            OrderId = orderId;
            ConsumerId = consumerId;
            RestaurantId = restaurantId;
            CreateDate = createDate;
        }

        public static Order CreateOrder(OrderDetails orderDetails) => new Order(0, orderDetails.ConsumerId, orderDetails.RestaurantId, DateTime.Now);

        public bool ChangeOrderStatus(OrderStatus status)
        {
            Status = status;

            return true;
        }

        public void AddOrderListItem(params OrderListItem[] items)
        {
            _orderListItems.AddRange(items);
        }
    }
}

namespace FastMeal.OrderService.Domain.Models
{
    public class Order
    {
        public long OrderId { get; init; }

        public int ConsumerId { get; set; }

        public int RestaurantId { get; set; }

        public int OrderStatus { get; set; }

        public IList<OrderListItem> OrderListItems { get; set; } = new List<OrderListItem>();


    }
}

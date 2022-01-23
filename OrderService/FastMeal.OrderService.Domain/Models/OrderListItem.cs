namespace FastMeal.OrderService.Domain.Models
{
    public class OrderListItem
    {
        public int MenuItemId { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
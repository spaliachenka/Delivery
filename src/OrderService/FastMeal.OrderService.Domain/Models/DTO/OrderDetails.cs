namespace FastMeal.OrderService.Domain.Models.DTO
{
    public record class OrderDetails(int ConsumerId, int RestaurantId, IEnumerable<OrderListItem> OrderListItems);
}

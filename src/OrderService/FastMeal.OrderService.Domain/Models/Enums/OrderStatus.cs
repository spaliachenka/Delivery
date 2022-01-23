namespace FastMeal.OrderService.Domain.Models.Enums
{
    public enum OrderStatus
    {
        Created = 1,
        AprovalPending = 2,
        Approved = 3,
        ReadyToPickup = 4,
        Canceled = 8,
        Rejected = 9,
        Delivered = 10,
    }
}

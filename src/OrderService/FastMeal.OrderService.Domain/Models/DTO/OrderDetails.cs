using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastMeal.OrderService.Domain.Models.DTO
{
    public record class OrderDetails(int ConsumerId, int RestaurantId, IEnumerable<OrderListItem> OrderListItems);
}

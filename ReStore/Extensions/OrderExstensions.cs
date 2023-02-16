using Microsoft.EntityFrameworkCore;
using ReStore.DTOs;
using ReStore.Entities.OrderAggregate;

namespace ReStore.Extensions
{
    public static class OrderExstensions
    {
            public static IQueryable<OrderDTO> ProjectOrderToOrderDTO(this IQueryable<Order> query)
            {
            return query
                .Select(order => new OrderDTO
                {
                    Id = order.Id,
                    BuyerId = order.BuyerId,
                    OrderDate = order.OrderDate,
                    ShippingAddress = order.ShippingAddress,
                    DeliveryFee = order.DeliveryFee,
                    Subtotal = order.Subtotal,
                    OrderStatus = order.OrderStatus.ToString(),
                    Total = order.GetTotal(),
                    OrderItems = order.OrderItems.Select(item => new OrderItemDTO
                    {
                        ProductId = item.ItemOrdered.ProductId,
                        Name = item.ItemOrdered.Name,
                        PictureUrl = item.ItemOrdered.PictureUrl,
                        Price = item.Price,
                        Quantity = item.Quantity
                    }).ToList()
                }).AsNoTracking();
            }
    }
}

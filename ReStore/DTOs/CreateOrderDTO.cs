using ReStore.Entities.OrderAggregate;

namespace ReStore.DTOs
{
    public class CreateOrderDTO
    {
        public bool SaveAddress { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
    }
}

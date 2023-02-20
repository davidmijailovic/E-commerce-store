using System.Collections.Generic;

namespace ReStore.DTOs
{
    public class BasketDTO
    {
        public int Id { get; set; }
        public string BuyerId { get; set; }
        public List<BasketItemDTO> Items { get; set; }
        public string PaymentIntentId { get; set; }
        public string ClientSecret { get; set; }
    }
}

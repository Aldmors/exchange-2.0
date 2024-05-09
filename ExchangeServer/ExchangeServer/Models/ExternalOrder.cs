namespace ExchangeServer.Models
{
    public class ExternalOrder
    {
        public int ExternalOrderId { get; set; }
        public string? OrderId { get; set; }
        public Client? ClientId { get; set; }
    }
}

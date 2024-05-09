using System.ComponentModel.DataAnnotations;

namespace ExchangeServer.Models
{
    public class Document
    {
        public int DocumentId { get; set; }
        public int ShipmentId { get; set; }
        public Shipment? Shipment { get; set; }
        public string? DocumentName { get; set; }
        public string? Type { get; set; }
        public string? Status { get; set; }
        public string? AdditionalInfo { get; set; }
        public DateTime CreateTime { get; set; }
    }
}

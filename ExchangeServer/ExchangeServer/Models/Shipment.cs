using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExchangeServer.Models
{
    public class Shipment
    {
        public int ShipmentId { get; set; }
        public ExternalOrder? ExOrderId { get; set; }
        public Label? LabelId { get; set; }
        public User? UserId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? Status { get; set; }
        public List<Document>? Documents { get; set; }
        public DateTime CreateTime { get; set; }
    }
}

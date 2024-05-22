using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExchangeServer.Models
{
    public class Shipment
    {

        public int ShipmentId { get; set; }
       
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? Status { get; set; }
        public DateTime CreateTime { get; set; }

        public ExternalOrder? ExternalOrder { get; set; }
        public User? User { get; set; }
        public ICollection<Document>? Documents { get; } = new List<Document>();
        public Label? Label { get; set; } = null!;
    }
}

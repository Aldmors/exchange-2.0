using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExchangeServer.Models
{
    public class Document
    {
        public int DocumentId { get; set; }
        public int ShipmentId { get; set; }
        public Shipment? Shipment { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? DocumentName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? Type { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? Status { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? AdditionalInfo { get; set; }
        public DateTime CreateTime { get; set; }
    }
}

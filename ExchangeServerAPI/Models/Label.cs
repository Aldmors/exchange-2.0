using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExchangeServerAPI.Models
{
    public class Label
    {
        public int LabelId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? ShippingType { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? ShippingId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? Status { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? Country { get; set; }
        public DateTime CreateTime { get; set; }
    }
}

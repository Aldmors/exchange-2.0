using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExchangeServer.Models
{
    public class ExternalOrder
    {
        public int ExternalOrderId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? OrderId { get; set; }
        public Client? ClientId { get; set; }
    }
}

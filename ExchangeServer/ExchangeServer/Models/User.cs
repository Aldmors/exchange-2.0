using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExchangeServer.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? ExternalId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? FirstName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? SecondName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)] 
        public string? Email { get; set; }
       
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }


        public Authentication? Authentication { get; set; }
        public Permission? Permission { get; set; }
        public Group? Group { get; set; }
        public int ShipmentId { get; set; }
        public Shipment Shipment { get; set; } = null!;

    }
}

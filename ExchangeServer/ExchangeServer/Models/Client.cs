using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExchangeServer.Models
{
    public class Client
    {
        public int ClientId { get; set; }
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
        public string? Phone { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? Address { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? StreetNumber { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? City { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? State { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? PostalCode { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? Country { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? Notes { get; set; }
    }
}

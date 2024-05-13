using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExchangeServerAPI.Models
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
        public Authentication? Password { get; set; }
        public Permission? Permission { get; set; }
        public Group? Group { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }

    }
}

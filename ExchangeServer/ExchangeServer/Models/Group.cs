using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExchangeServer.Models
{
    public class Group
    {

        public int GroupId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public required string GroupName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? Description { get; set; }
        public Permission? Permission { get; set; } = null!; 
        public int UserId { get; set; } 
        public User User { get; set; } = null!; 

    }
}

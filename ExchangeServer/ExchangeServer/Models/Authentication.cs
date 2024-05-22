using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ExchangeServer.Models
{
    public class Authentication
    {

        public int AuthenticationId { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? Password { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(250)]
        public string? TwoFa { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;

    }
}

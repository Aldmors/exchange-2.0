using System.ComponentModel.DataAnnotations;

namespace ExchangeServer.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string ExternalId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public Authentication Password { get; set; }
        public Permission Permission { get; set; }
        public Group Group { get; set; }
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }

    }
}

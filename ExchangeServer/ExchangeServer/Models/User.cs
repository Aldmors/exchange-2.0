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
        public int Password { get; set; }
        public int Permission { get; set; }
        public int Group { get; set; }
        public int Status { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreateTime { get; set; }

    }
}

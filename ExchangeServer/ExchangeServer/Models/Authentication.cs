namespace ExchangeServer.Models
{
    public class Authentication
    {
        public int AuthenticationId { get; set; }
        public string? Password { get; set; }
        public string? TwoFA { get; set; }
    }
}

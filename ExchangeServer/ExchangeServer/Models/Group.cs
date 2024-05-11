namespace ExchangeServer.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public required string GroupName { get; set; }
        public string? Description { get; set; }
        public Permission? Permission { get; set; }
    }
}

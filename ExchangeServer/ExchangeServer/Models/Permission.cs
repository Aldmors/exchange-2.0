namespace ExchangeServer.Models
{
    public class Permission
    {

        public int PermissionId { get; set; }
        public bool Statistics { get; set; }
        public bool CreateUsers { get; set; }
        public bool EditUsers { get; set; }
        public bool DeleteUsers { get; set; }
        public bool CreateGroups { get; set; }
        public bool EditGroups { get; set; }
        public bool DeleteGroups { get; set; }
        public bool ProblemSolving { get; set; }
        public bool Packaging { get; set; }
        public bool Admin { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; } = null!;
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}

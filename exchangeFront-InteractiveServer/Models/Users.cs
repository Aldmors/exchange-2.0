using System.ComponentModel.DataAnnotations;

namespace exchangeFront_InteractiveServer.Models;

    public class Users
{
    public int UserId { get; set; }
    public string ExternalId { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string Email { get; set; }
    public int Password { get; set; }
    public int Permission { get; set; }
    public int Group { get; set; }
    [DataType(DataType.Date)]
    public DateTime CreateTime { get; set; }
}


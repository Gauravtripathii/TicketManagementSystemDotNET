using TicketManagementSystem.Enums;

namespace TicketManagementSystem.Models
{
    public class User
    {
        public int UserId {get; set;}
        public string Name {get; set;}
        public string Email {get; set;}
        public UserRole Role {get; set;}
    }
}
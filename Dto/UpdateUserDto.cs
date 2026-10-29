using TicketManagementSystem.Enums;

namespace TicketManagementSystem.Dto
{
    public class UpdateUserDto
    {
        public string Name {get; set;}
        public string Email {get; set;}
        public UserRole Role {get; set;}
    }
}
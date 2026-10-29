using TicketManagementSystem.Enums;

namespace TicketManagementSystem.Dto
{
    public class UserResponseDto
    {
        public int UserId {get; set;}
        public string Name {get; set;}
        public string Email {get; set;}
        public UserRole Role {get; set;}
    }
}
using TicketManagementSystem.Enums;

namespace TicketManagementSystem.Dto
{
    public class CreateTicketDto
    {
        public string Title {get; set;}
        public string Description {get; set;}
        public TicketPriority Priority {get; set;}
        public int CreatedByUserId {get; set;}
    }
}

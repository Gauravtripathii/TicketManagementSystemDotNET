using TicketManagementSystem.Enums;

namespace TicketManagementSystem.Dto
{
    public class UpdateTicketDto
    {
        public string Title {get; set;}
        public string Description {get; set;}
        public TicketPriority Priority {get; set;}
    }
}

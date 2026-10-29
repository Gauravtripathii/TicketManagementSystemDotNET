using TicketManagementSystem.Enums;

namespace TicketManagementSystem.Dto
{
    public class UpdateTicketStatusDto
    {
        public int TicketId {get; set;}
        public TicketStatus Status {get; set;}
    }
}

using TicketManagementSystem.Enums;

namespace TicketManagementSystem.Dto
{
    public class TicketResponseDto
    {
        public int TicketId {get; set;}
        public string Title {get; set;}
        public string Description {get; set;}
        public TicketStatus Status {get; set;}
        public TicketPriority Priority {get; set;}
        public int CreatedByUserId {get; set;}
        public int AssignedToUserId {get; set;}
        public DateTime CreatedDate {get; set;} = DateTime.Now;
        public DateTime UpdatedDate {get; set;} = DateTime.Now;
    }
}

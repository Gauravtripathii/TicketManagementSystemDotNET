using TicketManagementSystem.Enums;

namespace TicketManagementSystem.Models
{
    public class Ticket
    {
        public int TicketId {get; set;}
        public string Title {get; set;}
        public string Description {get; set;}
        public TicketStatus Status {get; set;}
        public TicketPriority Priority {get; set;}
        public DateTime CreatedDate {get; set;} = DateTime.Now;
        public int AssignedTo {get; set;}   // id of the user
        public int CreatedBy {get; set;}    // id of the user
    }
}
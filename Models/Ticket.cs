using TicketManagementSystem.Enums;

namespace TicketManagementSystem.Models
{
    public class Ticket
    {
        public int TicketId {get; set;}
        public string Title {get; set;}
        public string Description {get; set;}
        public ICollection<Comment> Comments {get; set;}
        public TicketStatus Status {get; set;}
        public TicketPriority Priority {get; set;}
        public DateTime CreatedDate {get; set;} = DateTime.Now;
        public DateTime UpdatedDate {get; set;} = DateTime.Now;
        public int AssignedToUserId {get; set;}   // id of the user
        public int CreatedByUserId {get; set;}    // id of the user
    }
}
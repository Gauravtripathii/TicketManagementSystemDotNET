namespace TicketManagementSystem.Models
{
    public class Comment
    {
        public int CommentId {get; set;}
        public int TicketId {get; set;}
        public string Message {get; set;}
        public int CreatedBy {get; set;}    // user id
        public DateTime CreatedDate {get; set;} = DateTime.Now;
    }
}
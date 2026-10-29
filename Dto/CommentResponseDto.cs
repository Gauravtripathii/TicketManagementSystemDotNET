
namespace TicketManagementSystem.Dto
{
    public class CommentResponseDto
    {
        public int CommentId {get; set;}
        public int TicketId {get; set;}
        public string Message {get; set;}
        public int CreatedByUserId {get; set;}
        public DateTime CreatedDate {get; set;} = DateTime.Now;
    }
}

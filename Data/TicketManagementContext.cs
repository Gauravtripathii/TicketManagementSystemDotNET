
using Microsoft.EntityFrameworkCore;
using TicketManagementSystem.Models;

namespace TicketManagementSystem.Data
{
    public class TicketManagementContext: DbContext
    {
        public TicketManagementContext (DbContextOptions<TicketManagementContext> options) : base(options) {}

        public DbSet<User> Users {get; set;}
        public DbSet<Ticket> Ticket {get; set;}
        public DbSet<Comment> Comment {get; set;}
    }
}

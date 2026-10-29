
using Microsoft.EntityFrameworkCore;
using TicketManagementSystem.Models;

namespace TicketManagementSystem.Data
{
    public class TicketManagementContext: DbContext
    {
        public TicketManagementContext (DbContextOptions<TicketManagementContext> options) : base(options) {}

        public DbSet<User> Users {get; set;}
        public DbSet<Ticket> Tickets {get; set;}
        public DbSet<Comment> Comments {get; set;}
    }
}

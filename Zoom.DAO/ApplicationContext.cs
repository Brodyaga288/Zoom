using Microsoft.EntityFrameworkCore;
using Zoom.Domain.Models;

namespace Zoom.DAO;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; } 
    public DbSet<Recording> Recordings { get; set; }
    public DbSet<Participant> Participants { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Meeting> Meetings { get; set; }
    public DbSet<Chat> Chats { get; set; }
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }
}
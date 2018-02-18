using EventApplicationCore.Model;
using Microsoft.EntityFrameworkCore;

namespace EventApplicationCore.Concrete
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Registration> Registration { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Venue> Venue { get; set; }
       
       
        public DbSet<Dishtypes> Dishtypes { get; set; }
       
       
        public DbSet<BookingDetails> BookingDetails { get; set; }
        public DbSet<BookingVenue> BookingVenue { get; set; }
        public DbSet<Event> Event { get; set; }
        
    }
}

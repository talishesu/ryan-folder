using Microsoft.EntityFrameworkCore;

namespace ryan.Models.DataContexts
{
    public class RyanDbContext : DbContext
    {
        public RyanDbContext(DbContextOptions options):base(options)
        {

        }
        //public DbSet<Contact> Contacts { get; set; }


    }
}

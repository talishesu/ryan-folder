using Microsoft.EntityFrameworkCore;
using ryan.Models.Entities;

namespace ryan.Models.DataContexts
{
    public class RyanDbContext : DbContext
    {
        public RyanDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<About> About { get; set; }
        public DbSet<AboutMe> AboutMe { get; set; }
        public DbSet<MyServices> MyServices { get; set; }
        public DbSet<Pricing> Pricing { get; set; }
        public DbSet<PricingAdvantages> PricingAdvantages { get; set; }
        public DbSet<FunFact> FunFact { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Quote> Quote { get; set; }

    }
}

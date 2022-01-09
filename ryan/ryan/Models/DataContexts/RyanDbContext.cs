using Microsoft.EntityFrameworkCore;
using ryan.Models.Entities;

namespace ryan.Models.DataContexts
{
    public class RyanDbContext : DbContext
    {
        public RyanDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<InfoLayout> InfoLayout { get; set; }
        public DbSet<InfoLayoutJob> InfoLayoutJob { get; set; }
        public DbSet<AboutMe> AboutMe { get; set; }
        public DbSet<MyServices> MyServices { get; set; }
        public DbSet<Pricing> Pricing { get; set; }
        public DbSet<PricingAdvantages> PricingAdvantages { get; set; }
        public DbSet<FunFact> FunFact { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Quote> Quote { get; set; }
        public DbSet<Experience> Experience { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Design> Design { get; set; }
        public DbSet<Languages> Languages { get; set; }
        public DbSet<Coding> Coding { get; set; }
        public DbSet<Knowledge> Knowledge { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }
        public DbSet<Works> Works { get; set; }

    }
}

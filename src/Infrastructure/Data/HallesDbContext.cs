using Microsoft.EntityFrameworkCore;
using Monbsoft.IHalles.Application.Models;

namespace Monbsoft.IHalles.Infrastructure.Data
{
    public class HallesDbContext : DbContext
    {
        public HallesDbContext(DbContextOptions<HallesDbContext> options)
            : base(options)
        {
        }

        public DbSet<Halle> Halles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // IHalle
            builder.Entity<Halle>().OwnsOne(ih => ih.Location);
            builder.Entity<Halle>().OwnsOne(ih => ih.Address);
        }
    }
}

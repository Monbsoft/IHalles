using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Monbsoft.IHalles.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monbsoft.IHalles.Web.Data
{
    public class IHallesDbContext : IdentityDbContext
    {
        public IHallesDbContext(DbContextOptions<IHallesDbContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<IHalle> IHalles { get; set; }
      
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // IHalle
            builder.Entity<IHalle>().OwnsOne(ih => ih.Location);
            builder.Entity<IHalle>()
                .HasOne(ih => ih.Creator)
                .WithOne()
                .HasForeignKey<IHalle>(ih => ih.CreatorId);
        }
    }
}

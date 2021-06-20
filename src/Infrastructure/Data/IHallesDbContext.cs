using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Monbsoft.IHalles.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monbsoft.IHalles.Infrastructure.Data
{
    public class IHallesDbContext : DbContext
    {
        public IHallesDbContext(DbContextOptions<IHallesDbContext> options)
            : base(options)
        {
        }

        public DbSet<IHalle> IHalles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // IHalle
            builder.Entity<IHalle>().OwnsOne(ih => ih.Location);
            builder.Entity<IHalle>().OwnsOne(ih => ih.Address);
        }
    }
}

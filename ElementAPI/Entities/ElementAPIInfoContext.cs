using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElementAPI.Entities
{
    public class ElementAPIInfoContext : DbContext
    {
        //Method 2 to connect to DB: Using DbContext's constructor with an overload

        public DbSet<CityEntity> Cities { get; set; }
        public DbSet<LandmarkEntity> Landmakrs { get; set; }

        //Method 1 to connect to DB: Override the onConfigure() on DbContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Port=5432;User Id=postgres;password=postgres;Database=elementAPI";
            optionsBuilder.UseNpgsql(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CityEntity>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasMany(x => x.Landmarks).WithOne(y => y.City);
            });

            modelBuilder.Entity<LandmarkEntity>(e =>
            {
                e.HasKey(x => x.Id);
                e.HasOne(x => x.City).WithMany(y => y.Landmarks);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}

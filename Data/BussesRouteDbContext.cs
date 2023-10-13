using BussesRouteMiniProject.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BussesRouteMiniProject.Data
{
    public class BussesRouteDbContext : DbContext
    {
        public BussesRouteDbContext(DbContextOptions<BussesRouteDbContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Bus> Busses { get; set; } = null!;
        public DbSet<Stop> Stops { get; set; } = null!;
        public DbSet<BussesStops> BussesStops { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BussesStops>()
                .HasKey(k => new { k.StopId, k.BussId });

            base.OnModelCreating(modelBuilder);
        }
    }
}

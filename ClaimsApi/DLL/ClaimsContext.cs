using Microsoft.EntityFrameworkCore;
using ClaimsApi.Models;

namespace ClaimsApi.DLL
{
    public class ClaimsContext: DbContext
    {
        public ClaimsContext(DbContextOptions<ClaimsContext> options): base(options) { }

        public DbSet<Claims> UserClaims { get; set; }
        public DbSet<ClaimType> ClaimTypes { get; set; }
        public DbSet<ClaimUserDetails> UserDetails { get; set; }
        public DbSet<ClaimVehicleDetails> VehicleDetails { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<VehicleModels> Models { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Claims>()
                .Property(cl => cl.IsDeleted)
                .HasDefaultValueSql("1");
            modelBuilder.Entity<ClaimType>().ToTable(nameof(ClaimType));
            modelBuilder.Entity<ClaimUserDetails>().ToTable(nameof(ClaimUserDetails));
            modelBuilder.Entity<ClaimVehicleDetails>().ToTable(nameof(ClaimVehicleDetails));
            modelBuilder.Entity<State>()
                .HasMany(s => s.UserDetails)
                .WithOne(cu => cu.State)
                .OnDelete(DeleteBehavior.Restrict); 
            modelBuilder.Entity<Country>()
                .HasMany(c => c.UserDetails)
                .WithOne(cu => cu.Country)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<VehicleModels>().ToTable(nameof(VehicleModels));
            modelBuilder.Entity<Manufacturer>().ToTable(nameof(Manufacturer));
            // Data Seeding
            ClaimsApi.DLL.Configuration.Seed(modelBuilder);
        }
    }
}

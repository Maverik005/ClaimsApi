using ClaimsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ClaimsApi.DLL
{
    public class Configuration
    {
        public static    void Seed (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClaimType>()
                .HasData(
                    new ClaimType { Id = 1, Name = "Diesel Claim" },
                    new ClaimType { Id = 2, Name = "Insurance Claim" }
                );
            modelBuilder.Entity<Manufacturer>()
                .HasData(
                new Manufacturer { Id = 1, Name="Optimus" },
                new Manufacturer { Id=2, Name="Renegade"}
            );
            modelBuilder.Entity<VehicleModels>()
                .HasData(
                    new VehicleModels { Id = 1, Name = "Ironhide", ManufacturerId = 1 },
                    new VehicleModels { Id = 2, Name = "Bumble Bee", ManufacturerId = 1 },
                    new VehicleModels { Id = 3, Name = "Steele", ManufacturerId = 1 },
                    new VehicleModels { Id = 4, Name = "Koppers", ManufacturerId = 1 },
                    new VehicleModels { Id = 5, Name = "Megatron", ManufacturerId = 2 },
                    new VehicleModels { Id = 6, Name = "Prime", ManufacturerId = 2 },
                    new VehicleModels { Id = 7, Name = "Scream", ManufacturerId = 2 },
                    new VehicleModels { Id = 8, Name = "Rattle", ManufacturerId = 2 }

                );
            modelBuilder.Entity<Country>()
                .HasData(new Country { Id = 1, Name = "Deutschland" });
            modelBuilder.Entity<State>()
                .HasData(
                    new State { Id = 1, Name = "Baden-Württemberg", CountryId = 1 },
                    new State { Id = 2, Name = "Bavaria", CountryId = 1 },
                    new State { Id = 3, Name = "Hessen", CountryId = 1 },
                    new State { Id = 4, Name = "Lower Saxony", CountryId = 1 },
                    new State { Id = 5, Name = "Berlin", CountryId = 1 },
                    new State { Id = 6, Name = "Saxony", CountryId = 1 },
                    new State { Id = 7, Name = "Thuringia", CountryId = 1 },
                    new State { Id = 8, Name = "Rhineland-Palatinate", CountryId = 1 },
                    new State { Id = 9, Name = "Mecklenburg-Vorpommern", CountryId = 1 },
                    new State { Id = 10, Name = "Saxony-Anhalt", CountryId = 1 },
                    new State { Id = 11, Name = "Saarland", CountryId = 1 },
                    new State { Id = 12,Name = "North Rhine-Westphalia", CountryId = 1 },
                    new State { Id = 13, Name = "Hamburg", CountryId = 1 },
                    new State { Id = 14, Name = "Brandenburg", CountryId = 1 },
                    new State { Id = 15, Name = "Bremen", CountryId = 1 },
                    new State { Id = 16, Name = "Schleswig-Holstein", CountryId = 1 }
                );
        }
    }
}

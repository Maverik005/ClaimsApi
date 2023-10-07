﻿// <auto-generated />
using System;
using ClaimsApi.DLL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClaimsApi.Migrations
{
    [DbContext(typeof(ClaimsContext))]
    [Migration("20231007140214_PincodeMigration")]
    partial class PincodeMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClaimsApi.Models.ClaimType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClaimType", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Diesel Claim"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Insurance Claim"
                        });
                });

            modelBuilder.Entity("ClaimsApi.Models.ClaimUserDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CellPhoneNo")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClaimsId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HouseNo")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pincode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClaimsId")
                        .IsUnique();

                    b.HasIndex("CountryId");

                    b.HasIndex("StateId");

                    b.ToTable("ClaimUserDetails", (string)null);
                });

            modelBuilder.Entity("ClaimsApi.Models.ClaimVehicleDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClaimsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfPurchase")
                        .HasColumnType("datetime2");

                    b.Property<int>("KilometersDriven")
                        .HasColumnType("int");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ManufacturingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<double>("PurchasePrise")
                        .HasColumnType("float");

                    b.Property<string>("VehicleFIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClaimsId")
                        .IsUnique();

                    b.ToTable("ClaimVehicleDetails", (string)null);
                });

            modelBuilder.Entity("ClaimsApi.Models.Claims", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimManager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClaimTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("0");

                    b.HasKey("Id");

                    b.HasIndex("ClaimTypeId");

                    b.ToTable("Claims");
                });

            modelBuilder.Entity("ClaimsApi.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Deutschland"
                        });
                });

            modelBuilder.Entity("ClaimsApi.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Manufacturer", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Optimus"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Renegade"
                        });
                });

            modelBuilder.Entity("ClaimsApi.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Baden-Württemberg"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 1,
                            Name = "Bavaria"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 1,
                            Name = "Hessen"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 1,
                            Name = "Lower Saxony"
                        },
                        new
                        {
                            Id = 5,
                            CountryId = 1,
                            Name = "Berlin"
                        },
                        new
                        {
                            Id = 6,
                            CountryId = 1,
                            Name = "Saxony"
                        },
                        new
                        {
                            Id = 7,
                            CountryId = 1,
                            Name = "Thuringia"
                        },
                        new
                        {
                            Id = 8,
                            CountryId = 1,
                            Name = "Rhineland-Palatinate"
                        },
                        new
                        {
                            Id = 9,
                            CountryId = 1,
                            Name = "Mecklenburg-Vorpommern"
                        },
                        new
                        {
                            Id = 10,
                            CountryId = 1,
                            Name = "Saxony-Anhalt"
                        },
                        new
                        {
                            Id = 11,
                            CountryId = 1,
                            Name = "Saarland"
                        },
                        new
                        {
                            Id = 12,
                            CountryId = 1,
                            Name = "North Rhine-Westphalia"
                        },
                        new
                        {
                            Id = 13,
                            CountryId = 1,
                            Name = "Hamburg"
                        },
                        new
                        {
                            Id = 14,
                            CountryId = 1,
                            Name = "Brandenburg"
                        },
                        new
                        {
                            Id = 15,
                            CountryId = 1,
                            Name = "Bremen"
                        },
                        new
                        {
                            Id = 16,
                            CountryId = 1,
                            Name = "Schleswig-Holstein"
                        });
                });

            modelBuilder.Entity("ClaimsApi.Models.VehicleModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("VehicleModels", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ManufacturerId = 1,
                            Name = "Ironhide"
                        },
                        new
                        {
                            Id = 2,
                            ManufacturerId = 1,
                            Name = "Bumble Bee"
                        },
                        new
                        {
                            Id = 3,
                            ManufacturerId = 1,
                            Name = "Steele"
                        },
                        new
                        {
                            Id = 4,
                            ManufacturerId = 1,
                            Name = "Koppers"
                        },
                        new
                        {
                            Id = 5,
                            ManufacturerId = 2,
                            Name = "Megatron"
                        },
                        new
                        {
                            Id = 6,
                            ManufacturerId = 2,
                            Name = "Prime"
                        },
                        new
                        {
                            Id = 7,
                            ManufacturerId = 2,
                            Name = "Scream"
                        },
                        new
                        {
                            Id = 8,
                            ManufacturerId = 2,
                            Name = "Rattle"
                        });
                });

            modelBuilder.Entity("ClaimsApi.Models.ClaimUserDetails", b =>
                {
                    b.HasOne("ClaimsApi.Models.Claims", "Claims")
                        .WithOne("ClaimUserDetails")
                        .HasForeignKey("ClaimsApi.Models.ClaimUserDetails", "ClaimsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClaimsApi.Models.Country", "Country")
                        .WithMany("UserDetails")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ClaimsApi.Models.State", "State")
                        .WithMany("UserDetails")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Claims");

                    b.Navigation("Country");

                    b.Navigation("State");
                });

            modelBuilder.Entity("ClaimsApi.Models.ClaimVehicleDetails", b =>
                {
                    b.HasOne("ClaimsApi.Models.Claims", "Claims")
                        .WithOne("ClaimVehicleDetails")
                        .HasForeignKey("ClaimsApi.Models.ClaimVehicleDetails", "ClaimsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Claims");
                });

            modelBuilder.Entity("ClaimsApi.Models.Claims", b =>
                {
                    b.HasOne("ClaimsApi.Models.ClaimType", "ClaimType")
                        .WithMany("UserClaims")
                        .HasForeignKey("ClaimTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClaimType");
                });

            modelBuilder.Entity("ClaimsApi.Models.State", b =>
                {
                    b.HasOne("ClaimsApi.Models.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ClaimsApi.Models.VehicleModels", b =>
                {
                    b.HasOne("ClaimsApi.Models.Manufacturer", "Manufacturer")
                        .WithMany("Models")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("ClaimsApi.Models.ClaimType", b =>
                {
                    b.Navigation("UserClaims");
                });

            modelBuilder.Entity("ClaimsApi.Models.Claims", b =>
                {
                    b.Navigation("ClaimUserDetails")
                        .IsRequired();

                    b.Navigation("ClaimVehicleDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("ClaimsApi.Models.Country", b =>
                {
                    b.Navigation("States");

                    b.Navigation("UserDetails");
                });

            modelBuilder.Entity("ClaimsApi.Models.Manufacturer", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("ClaimsApi.Models.State", b =>
                {
                    b.Navigation("UserDetails");
                });
#pragma warning restore 612, 618
        }
    }
}

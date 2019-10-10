﻿// <auto-generated />
using System;
using CarShareV1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarShareV1.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190513100604_isvalid")]
    partial class isvalid
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarShare.Data.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("County");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("HouseNumber");

                    b.Property<double>("Latitue");

                    b.Property<double>("Longitute");

                    b.Property<string>("PostCode");

                    b.Property<string>("Street");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("CarShare.Data.Agreement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Agreements");
                });

            modelBuilder.Entity("CarShare.Data.BankTransaction", b =>
                {
                    b.Property<string>("TransactionId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<string>("FullName");

                    b.Property<int>("OrderId");

                    b.Property<string>("Status");

                    b.Property<string>("UserId");

                    b.HasKey("TransactionId");

                    b.ToTable("BankTransactions");
                });

            modelBuilder.Entity("CarShare.Data.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BranchName");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("CarShare.Data.BranchAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchId");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("County");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("HouseNumber");

                    b.Property<double>("Latitue");

                    b.Property<double>("Longitute");

                    b.Property<string>("PostCode");

                    b.Property<string>("Street");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("BranchAddresses");
                });

            modelBuilder.Entity("CarShare.Data.DrivingLicence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("ExpireDate");

                    b.Property<string>("Image");

                    b.Property<bool>("IsValid");

                    b.Property<DateTime>("IssueDate");

                    b.Property<string>("LicenseNumber");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("DrivingLicences");
                });

            modelBuilder.Entity("CarShare.Data.EmailSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("FromEmail");

                    b.Property<string>("Password");

                    b.Property<int>("Port");

                    b.Property<bool>("SSL");

                    b.Property<string>("Smtp");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("EmailSettings");
                });

            modelBuilder.Entity("CarShare.Data.Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId");

                    b.Property<int>("VehicleId");

                    b.HasKey("Id");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("CarShare.Data.Insurance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("ExpireDate");

                    b.Property<DateTime>("IssueDate");

                    b.Property<string>("PolicyNumber");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Insurances");
                });

            modelBuilder.Entity("CarShare.Data.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("DropOffTime");

                    b.Property<bool>("IsPaid");

                    b.Property<DateTime>("PickUpDate");

                    b.Property<string>("PickUpTime");

                    b.Property<int>("ReservationId");

                    b.Property<double>("TotalAmount");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("UserId");

                    b.Property<int>("VehicleId");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CarShare.Data.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("DropOffTime");

                    b.Property<bool>("IsConfirmed");

                    b.Property<DateTime>("PickUpDate");

                    b.Property<double>("PickUpLocationLatitue");

                    b.Property<double>("PickUpLocationLongitute");

                    b.Property<string>("PickUpTime");

                    b.Property<double>("ReturnLocationLatitue");

                    b.Property<double>("ReturnLocationLongitute");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId");

                    b.Property<int>("VehicleId");

                    b.HasKey("Id");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("CarShare.Data.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description");

                    b.Property<int>("Rating");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId");

                    b.Property<int>("VehicleId");

                    b.HasKey("Id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("CarShare.Data.UserApplication", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DOB");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int>("Gender");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CarShare.Data.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Co2Emissions");

                    b.Property<string>("Colour");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CylinderCapacity");

                    b.Property<string>("DateOfFirstRegistration");

                    b.Property<string>("FuelType");

                    b.Property<string>("Image");

                    b.Property<string>("Model");

                    b.Property<bool>("Mot");

                    b.Property<string>("MotDetails");

                    b.Property<int>("NumberOfDoors");

                    b.Property<double>("PricePerHour");

                    b.Property<double>("Rating");

                    b.Property<string>("Registration");

                    b.Property<string>("RevenueWeight");

                    b.Property<string>("SixMonthRate");

                    b.Property<string>("TaxDetails");

                    b.Property<string>("TaxStatus");

                    b.Property<bool>("Taxed");

                    b.Property<string>("Transmission");

                    b.Property<string>("TwelveMonthRate");

                    b.Property<string>("TypeApproval");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId");

                    b.Property<string>("VIN");

                    b.Property<string>("WheelPlan");

                    b.Property<string>("YearOfManufacture");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("CarShare.Data.VehicleAvailability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookingTime");

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("Date");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId");

                    b.Property<int>("VehicleId");

                    b.HasKey("Id");

                    b.ToTable("VehicleAvailabilities");
                });

            modelBuilder.Entity("CarShare.Data.VehicleCurrentLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<double>("Latitue");

                    b.Property<double>("Longitute");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId");

                    b.Property<int>("VehicleId");

                    b.HasKey("Id");

                    b.ToTable("VehicleCurrentLocations");
                });

            modelBuilder.Entity("CarShare.Data.WebSiteSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressAPI");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("DVLAAPI");

                    b.Property<string>("MobileApiKey");

                    b.Property<string>("MobileApiSecret");

                    b.Property<string>("MobileWebsiteName");

                    b.Property<string>("PaymentAPI");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("WebSiteSettings");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CarShare.Data.UserApplication")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CarShare.Data.UserApplication")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CarShare.Data.UserApplication")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CarShare.Data.UserApplication")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

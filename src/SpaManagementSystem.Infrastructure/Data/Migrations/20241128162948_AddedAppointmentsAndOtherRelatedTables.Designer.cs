﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SpaManagementSystem.Infrastructure.Data.Context;

#nullable disable

namespace SpaManagementSystem.Infrastructure.Data.Migrations
{
    [DbContext(typeof(SmsDbContext))]
    [Migration("20241128162948_AddedAppointmentsAndOtherRelatedTables")]
    partial class AddedAppointmentsAndOtherRelatedTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("SMS")
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EmployeeService", b =>
                {
                    b.Property<Guid>("EmployeesId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ServicesId")
                        .HasColumnType("uuid");

                    b.HasKey("EmployeesId", "ServicesId");

                    b.HasIndex("ServicesId");

                    b.ToTable("EmployeeServices", "SMS");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("Roles", "SMS");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80d977c5-10d6-4b9b-b3f4-ff47e5759519"),
                            ConcurrencyStamp = "8b96cb46-04a9-4ce7-bf60-405c605bbc7d",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("f72d6760-503e-42cc-a70d-6909dbff3315"),
                            ConcurrencyStamp = "1090bc97-ddd5-4f41-af47-310c4e5c5016",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = new Guid("d659662c-558b-47f9-be26-e749d6cf9afa"),
                            ConcurrencyStamp = "b6d4f48a-f43b-4d40-8ec9-735a626eac71",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", "SMS");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", "SMS");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins", "SMS");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", "SMS");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", "SMS");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.Appointment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<Guid>("SalonId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("SalonId");

                    b.ToTable("Appointments", "SMS");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.AppointmentService", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AppointmentId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<Guid>("SalonId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("SalonId");

                    b.HasIndex("ServiceId");

                    b.ToTable("AppointmentServices", "SMS");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("SalonId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("SalonId");

                    b.ToTable("Customers", "SMS");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("EmploymentStatus")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("HireDate")
                        .HasColumnType("date");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("SalonId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SalonId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Employees", "SMS");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.EmployeeAvailability", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeAvailabilities", "SMS");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<Guid>("AppointmentId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Method")
                        .HasColumnType("integer");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("SalonId")
                        .HasColumnType("uuid");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("SalonId");

                    b.ToTable("Payments", "SMS");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<int>("MinimumStockQuantity")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PurchaseTaxRate")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("numeric");

                    b.Property<decimal>("SaleTaxRate")
                        .HasColumnType("numeric");

                    b.Property<Guid>("SalonId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("StockQuantity")
                        .HasColumnType("numeric");

                    b.Property<string>("UnitOfMeasure")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("SalonId");

                    b.ToTable("Products", "SMS");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ExpirationTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("RefreshTokens", "SMS");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.Salon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Salons", "SMS");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("interval");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<Guid>("SalonId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("TaxRate")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("SalonId");

                    b.ToTable("Services", "SMS");
                });

            modelBuilder.Entity("SpaManagementSystem.Infrastructure.Identity.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("Users", "SMS");
                });

            modelBuilder.Entity("EmployeeService", b =>
                {
                    b.HasOne("SpaManagementSystem.Domain.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpaManagementSystem.Domain.Entities.Service", null)
                        .WithMany()
                        .HasForeignKey("ServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("SpaManagementSystem.Infrastructure.Identity.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("SpaManagementSystem.Infrastructure.Identity.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpaManagementSystem.Infrastructure.Identity.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("SpaManagementSystem.Infrastructure.Identity.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.Appointment", b =>
                {
                    b.HasOne("SpaManagementSystem.Domain.Entities.Customer", "Customer")
                        .WithMany("Appointments")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpaManagementSystem.Domain.Entities.Employee", "Employee")
                        .WithMany("Appointments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpaManagementSystem.Domain.Entities.Salon", "Salon")
                        .WithMany("Appointments")
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.AppointmentService", b =>
                {
                    b.HasOne("SpaManagementSystem.Domain.Entities.Appointment", "Appointment")
                        .WithMany("AppointmentServices")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpaManagementSystem.Domain.Entities.Salon", "Salon")
                        .WithMany()
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpaManagementSystem.Domain.Entities.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");

                    b.Navigation("Salon");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.Customer", b =>
                {
                    b.HasOne("SpaManagementSystem.Domain.Entities.Salon", "Salon")
                        .WithMany("Customers")
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.Employee", b =>
                {
                    b.HasOne("SpaManagementSystem.Domain.Entities.Salon", "Salon")
                        .WithMany("Employees")
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpaManagementSystem.Infrastructure.Identity.Entities.User", null)
                        .WithOne()
                        .HasForeignKey("SpaManagementSystem.Domain.Entities.Employee", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("SpaManagementSystem.Domain.Entities.EmployeeProfile", "Profile", b1 =>
                        {
                            b1.Property<Guid>("EmployeeId")
                                .HasColumnType("uuid");

                            b1.Property<DateOnly>("DateOfBirth")
                                .HasColumnType("date");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<int>("Gender")
                                .HasColumnType("integer");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("PhoneNumber")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("EmployeeId");

                            b1.ToTable("EmployeeProfiles", "SMS");

                            b1.WithOwner()
                                .HasForeignKey("EmployeeId");
                        });

                    b.Navigation("Profile")
                        .IsRequired();

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.EmployeeAvailability", b =>
                {
                    b.HasOne("SpaManagementSystem.Domain.Entities.Employee", "Employee")
                        .WithMany("EmployeeAvailabilities")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsMany("SpaManagementSystem.Domain.ValueObjects.AvailableHours", "AvailableHours", b1 =>
                        {
                            b1.Property<Guid>("EmployeeAvailabilityId")
                                .HasColumnType("uuid");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<int>("Id"));

                            b1.Property<TimeSpan>("End")
                                .HasColumnType("interval");

                            b1.Property<TimeSpan>("Start")
                                .HasColumnType("interval");

                            b1.HasKey("EmployeeAvailabilityId", "Id");

                            b1.ToTable("EmployeeAvailabilityHours", "SMS");

                            b1.WithOwner()
                                .HasForeignKey("EmployeeAvailabilityId");
                        });

                    b.Navigation("AvailableHours");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.Payment", b =>
                {
                    b.HasOne("SpaManagementSystem.Domain.Entities.Appointment", "Appointment")
                        .WithMany("Payments")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SpaManagementSystem.Domain.Entities.Salon", "Salon")
                        .WithMany()
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.Product", b =>
                {
                    b.HasOne("SpaManagementSystem.Domain.Entities.Salon", "Salon")
                        .WithMany("Products")
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.Salon", b =>
                {
                    b.OwnsOne("SpaManagementSystem.Domain.ValueObjects.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("SalonId")
                                .HasColumnType("uuid");

                            b1.Property<string>("BuildingNumber")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("Region")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("SalonId");

                            b1.ToTable("Salons", "SMS");

                            b1.WithOwner()
                                .HasForeignKey("SalonId");
                        });

                    b.OwnsMany("SpaManagementSystem.Domain.ValueObjects.OpeningHours", "OpeningHours", b1 =>
                        {
                            b1.Property<Guid>("SalonId")
                                .HasColumnType("uuid");

                            b1.Property<int>("DayOfWeek")
                                .HasColumnType("integer");

                            b1.Property<TimeSpan>("ClosingTime")
                                .HasColumnType("interval");

                            b1.Property<TimeSpan>("OpeningTime")
                                .HasColumnType("interval");

                            b1.HasKey("SalonId", "DayOfWeek");

                            b1.ToTable("OpeningHours", "SMS");

                            b1.WithOwner()
                                .HasForeignKey("SalonId");
                        });

                    b.Navigation("Address");

                    b.Navigation("OpeningHours");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.Service", b =>
                {
                    b.HasOne("SpaManagementSystem.Domain.Entities.Salon", "Salon")
                        .WithMany("Services")
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.Appointment", b =>
                {
                    b.Navigation("AppointmentServices");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.Customer", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.Employee", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("EmployeeAvailabilities");
                });

            modelBuilder.Entity("SpaManagementSystem.Domain.Entities.Salon", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Customers");

                    b.Navigation("Employees");

                    b.Navigation("Products");

                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using FMA.Application.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FMA.Application.Migrations
{
    [DbContext(typeof(FreelancerContext))]
    [Migration("20240611035524_Mig4")]
    partial class Mig4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExpertiseFreelancer", b =>
                {
                    b.Property<int>("FreelancerId")
                        .HasColumnType("int");

                    b.Property<int>("ExpertiseId")
                        .HasColumnType("int");

                    b.HasKey("FreelancerId", "ExpertiseId");

                    b.HasIndex("ExpertiseId");

                    b.ToTable("ExpertiseFreelancer", (string)null);

                    b.HasData(
                        new
                        {
                            FreelancerId = 1,
                            ExpertiseId = 3
                        },
                        new
                        {
                            FreelancerId = 1,
                            ExpertiseId = 1
                        },
                        new
                        {
                            FreelancerId = 1,
                            ExpertiseId = 2
                        },
                        new
                        {
                            FreelancerId = 2,
                            ExpertiseId = 2
                        },
                        new
                        {
                            FreelancerId = 3,
                            ExpertiseId = 2
                        },
                        new
                        {
                            FreelancerId = 3,
                            ExpertiseId = 1
                        },
                        new
                        {
                            FreelancerId = 4,
                            ExpertiseId = 3
                        },
                        new
                        {
                            FreelancerId = 4,
                            ExpertiseId = 4
                        },
                        new
                        {
                            FreelancerId = 5,
                            ExpertiseId = 3
                        },
                        new
                        {
                            FreelancerId = 5,
                            ExpertiseId = 1
                        });
                });

            modelBuilder.Entity("FMA.Application.Entities.Domain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BorderColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DomainName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Domains");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BorderColor = "#fdf1d3",
                            DomainName = "Manual Labor",
                            PhotoPath = "https://freelanceme.blob.core.windows.net/container1/manual_labor"
                        },
                        new
                        {
                            Id = 2,
                            BorderColor = "#f3fee7",
                            DomainName = "Domestic Services",
                            PhotoPath = "https://freelanceme.blob.core.windows.net/container1/domestic_services"
                        },
                        new
                        {
                            Id = 3,
                            BorderColor = "#fee7e7",
                            DomainName = "Health & Welness ",
                            PhotoPath = "https://freelanceme.blob.core.windows.net/container1/health_and_wellness"
                        },
                        new
                        {
                            Id = 4,
                            BorderColor = "#e7edfe",
                            DomainName = "Business Services",
                            PhotoPath = "https://freelanceme.blob.core.windows.net/container1/business_services"
                        },
                        new
                        {
                            Id = 5,
                            BorderColor = "#ffeab5",
                            DomainName = "Home Technology",
                            PhotoPath = "https://freelanceme.blob.core.windows.net/container1/home_technology"
                        },
                        new
                        {
                            Id = 6,
                            BorderColor = "#dcffb5",
                            DomainName = "Pet Care",
                            PhotoPath = "https://freelanceme.blob.core.windows.net/container1/pets"
                        },
                        new
                        {
                            Id = 7,
                            BorderColor = "#fdf1d3",
                            DomainName = "Performing Arts",
                            PhotoPath = "https://freelanceme.blob.core.windows.net/container1/performing_arts"
                        });
                });

            modelBuilder.Entity("FMA.Application.Entities.Expertise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BorderColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DomainId")
                        .HasColumnType("int");

                    b.Property<string>("ExpertiseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DomainId");

                    b.ToTable("Expertises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BorderColor = "#fdf1d3",
                            DomainId = 1,
                            ExpertiseName = "Furniture assembler",
                            PhotoPath = "https://freelanceme.blob.core.windows.net/container1/furniture_assembler"
                        },
                        new
                        {
                            Id = 2,
                            BorderColor = "#f3fee7",
                            DomainId = 1,
                            ExpertiseName = "Chauffeur",
                            PhotoPath = "https://freelanceme.blob.core.windows.net/container1/chauffeur"
                        },
                        new
                        {
                            Id = 3,
                            BorderColor = "#fee7e7",
                            DomainId = 1,
                            ExpertiseName = "Painter",
                            PhotoPath = "https://freelanceme.blob.core.windows.net/container1/painter"
                        },
                        new
                        {
                            Id = 4,
                            BorderColor = "#e7edfe",
                            DomainId = 1,
                            ExpertiseName = "Carpenter",
                            PhotoPath = "https://freelanceme.blob.core.windows.net/container1/carpenter"
                        },
                        new
                        {
                            Id = 5,
                            BorderColor = "#ffeab5",
                            DomainId = 1,
                            ExpertiseName = "Roof repairer",
                            PhotoPath = "https://freelanceme.blob.core.windows.net/container1/roof_repairer"
                        },
                        new
                        {
                            Id = 6,
                            BorderColor = "#dcffb5",
                            DomainId = 1,
                            ExpertiseName = "Packer",
                            PhotoPath = "https://freelanceme.blob.core.windows.net/container1/packing_service"
                        },
                        new
                        {
                            Id = 7,
                            BorderColor = "#fdf1d3",
                            DomainId = 1,
                            ExpertiseName = "Window cleaner",
                            PhotoPath = "https://freelanceme.blob.core.windows.net/container1/window_cleaner"
                        },
                        new
                        {
                            Id = 8,
                            BorderColor = "#f3fee7",
                            DomainId = 1,
                            ExpertiseName = "Yard worker",
                            PhotoPath = "https://freelanceme.blob.core.windows.net/container1/yard_worker"
                        });
                });

            modelBuilder.Entity("FMA.Application.Entities.Freelancer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateRegistered")
                        .HasColumnType("datetime2");

                    b.Property<int>("DomainId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FulfilledContracts")
                        .HasColumnType("int");

                    b.Property<decimal>("HourlyRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("HoursBilled")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MainExpertiseId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DomainId");

                    b.ToTable("Freelancers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateRegistered = new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc),
                            DomainId = 1,
                            Email = "nadia@example.com",
                            FirstName = "Nadia",
                            FulfilledContracts = 15,
                            HourlyRate = 55m,
                            HoursBilled = 300,
                            IsActive = true,
                            LastName = "Al-Saud",
                            Latitude = 26.4207m,
                            Longitude = 50.0888m,
                            MainExpertiseId = 3,
                            PhoneNumber = "+966504567890",
                            PhotoPath = "/images/nadia.jpg",
                            Rating = 4.7m
                        },
                        new
                        {
                            Id = 2,
                            DateRegistered = new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Utc),
                            DomainId = 1,
                            Email = "khalid@example.com",
                            FirstName = "Khalid",
                            FulfilledContracts = 18,
                            HourlyRate = 45m,
                            HoursBilled = 350,
                            IsActive = true,
                            LastName = "Al-Farsi",
                            Latitude = 23.8859m,
                            Longitude = 45.0792m,
                            MainExpertiseId = 2,
                            PhoneNumber = "+966509876543",
                            PhotoPath = "/images/khalid.jpg",
                            Rating = 4.6m
                        },
                        new
                        {
                            Id = 3,
                            DateRegistered = new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Utc),
                            DomainId = 1,
                            Email = "sara@example.com",
                            FirstName = "Sara",
                            FulfilledContracts = 30,
                            HourlyRate = 65m,
                            HoursBilled = 600,
                            IsActive = true,
                            LastName = "Al-Qahtani",
                            Latitude = 24.7743m,
                            Longitude = 46.7384m,
                            MainExpertiseId = 2,
                            PhoneNumber = "+966501234567",
                            PhotoPath = "/images/sara.jpg",
                            Rating = 4.9m
                        },
                        new
                        {
                            Id = 4,
                            DateRegistered = new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc),
                            DomainId = 1,
                            Email = "yousef@example.com",
                            FirstName = "Yousef",
                            FulfilledContracts = 22,
                            HourlyRate = 70m,
                            HoursBilled = 450,
                            IsActive = true,
                            LastName = "Al-Ghamdi",
                            Latitude = 21.4858m,
                            Longitude = 39.1925m,
                            MainExpertiseId = 4,
                            PhoneNumber = "+966504321098",
                            PhotoPath = "/images/yousef.jpg",
                            Rating = 4.5m
                        },
                        new
                        {
                            Id = 5,
                            DateRegistered = new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Utc),
                            DomainId = 1,
                            Email = "layla@example.com",
                            FirstName = "Layla",
                            FulfilledContracts = 28,
                            HourlyRate = 55m,
                            HoursBilled = 550,
                            IsActive = true,
                            LastName = "Al-Omari",
                            Latitude = 26.4207m,
                            Longitude = 50.0888m,
                            MainExpertiseId = 1,
                            PhoneNumber = "+966509876543",
                            PhotoPath = "/images/layla.jpg",
                            Rating = 4.8m
                        },
                        new
                        {
                            Id = 6,
                            DateRegistered = new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Utc),
                            DomainId = 2,
                            Email = "omar@example.com",
                            FirstName = "Omar",
                            FulfilledContracts = 19,
                            HourlyRate = 60m,
                            HoursBilled = 380,
                            IsActive = true,
                            LastName = "Al-Zahrani",
                            Latitude = 23.8859m,
                            Longitude = 45.0792m,
                            MainExpertiseId = 3,
                            PhoneNumber = "+966501234567",
                            PhotoPath = "/images/omar.jpg",
                            Rating = 4.7m
                        },
                        new
                        {
                            Id = 7,
                            DateRegistered = new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Utc),
                            DomainId = 2,
                            Email = "huda@example.com",
                            FirstName = "Huda",
                            FulfilledContracts = 24,
                            HourlyRate = 65m,
                            HoursBilled = 500,
                            IsActive = true,
                            LastName = "Al-Muhanna",
                            Latitude = 24.7743m,
                            Longitude = 46.7384m,
                            MainExpertiseId = 3,
                            PhoneNumber = "+966504567890",
                            PhotoPath = "/images/huda.jpg",
                            Rating = 4.6m
                        },
                        new
                        {
                            Id = 8,
                            DateRegistered = new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Utc),
                            DomainId = 2,
                            Email = "fahad@example.com",
                            FirstName = "Fahad",
                            FulfilledContracts = 32,
                            HourlyRate = 50m,
                            HoursBilled = 640,
                            IsActive = true,
                            LastName = "Al-Rashidi",
                            Latitude = 24.7136m,
                            Longitude = 46.6753m,
                            MainExpertiseId = 3,
                            PhoneNumber = "+966501234567",
                            PhotoPath = "/images/fahad.jpg",
                            Rating = 4.9m
                        },
                        new
                        {
                            Id = 9,
                            DateRegistered = new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Utc),
                            DomainId = 2,
                            Email = "amal@example.com",
                            FirstName = "Amal",
                            FulfilledContracts = 26,
                            HourlyRate = 55m,
                            HoursBilled = 520,
                            IsActive = true,
                            LastName = "Al-Mutairi",
                            Latitude = 21.4858m,
                            Longitude = 39.1925m,
                            MainExpertiseId = 3,
                            PhoneNumber = "+966501111222",
                            PhotoPath = "/images/amal.jpg",
                            Rating = 4.8m
                        },
                        new
                        {
                            Id = 10,
                            DateRegistered = new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Utc),
                            DomainId = 2,
                            Email = "abdullah@example.com",
                            FirstName = "Abdullah",
                            FulfilledContracts = 21,
                            HourlyRate = 70m,
                            HoursBilled = 420,
                            IsActive = true,
                            LastName = "Al-Qassem",
                            Latitude = 26.4207m,
                            Longitude = 50.0888m,
                            MainExpertiseId = 3,
                            PhoneNumber = "+966509876543",
                            PhotoPath = "/images/abdullah.jpg",
                            Rating = 4.7m
                        },
                        new
                        {
                            Id = 11,
                            DateRegistered = new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Utc),
                            DomainId = 2,
                            Email = "noura@example.com",
                            FirstName = "Noura",
                            FulfilledContracts = 29,
                            HourlyRate = 60m,
                            HoursBilled = 580,
                            IsActive = true,
                            LastName = "Al-Sulaiman",
                            Latitude = 23.8859m,
                            Longitude = 45.0792m,
                            MainExpertiseId = 3,
                            PhoneNumber = "+966504321098",
                            PhotoPath = "/images/noura.jpg",
                            Rating = 4.9m
                        });
                });

            modelBuilder.Entity("ExpertiseFreelancer", b =>
                {
                    b.HasOne("FMA.Application.Entities.Expertise", null)
                        .WithMany()
                        .HasForeignKey("ExpertiseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FMA.Application.Entities.Freelancer", null)
                        .WithMany()
                        .HasForeignKey("FreelancerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FMA.Application.Entities.Expertise", b =>
                {
                    b.HasOne("FMA.Application.Entities.Domain", "Domain")
                        .WithMany("Expertises")
                        .HasForeignKey("DomainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Domain");
                });

            modelBuilder.Entity("FMA.Application.Entities.Freelancer", b =>
                {
                    b.HasOne("FMA.Application.Entities.Domain", "Domain")
                        .WithMany("Freelancers")
                        .HasForeignKey("DomainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Domain");
                });

            modelBuilder.Entity("FMA.Application.Entities.Domain", b =>
                {
                    b.Navigation("Expertises");

                    b.Navigation("Freelancers");
                });
#pragma warning restore 612, 618
        }
    }
}

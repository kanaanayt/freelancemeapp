﻿// <auto-generated />
using System;
using FMA.Application.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FMA.Application.Migrations
{
    [DbContext(typeof(FreelancerContext))]
    partial class FreelancerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ExpertiseFreelancer", b =>
                {
                    b.Property<int>("FreelancerId")
                        .HasColumnType("integer");

                    b.Property<int>("ExpertiseId")
                        .HasColumnType("integer");

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
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DomainName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FontFamily")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Domains");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DomainName = "Manual Labor",
                            FontFamily = "Times New Roman",
                            PhotoPath = "/images/manual"
                        },
                        new
                        {
                            Id = 2,
                            DomainName = "Domestic Services",
                            FontFamily = "Helvetica",
                            PhotoPath = "/images/domestic"
                        },
                        new
                        {
                            Id = 3,
                            DomainName = "Health & Welness ",
                            FontFamily = "Courier New",
                            PhotoPath = "/images/health"
                        },
                        new
                        {
                            Id = 4,
                            DomainName = "Business Services",
                            FontFamily = "Verdana",
                            PhotoPath = "/images/business"
                        },
                        new
                        {
                            Id = 5,
                            DomainName = "Home Technology",
                            FontFamily = "Arial",
                            PhotoPath = "/images/hometech"
                        },
                        new
                        {
                            Id = 6,
                            DomainName = "Pet Care",
                            FontFamily = "Century Gothic",
                            PhotoPath = "/images/petcare"
                        },
                        new
                        {
                            Id = 7,
                            DomainName = "Performing Arts",
                            FontFamily = "Cambria",
                            PhotoPath = "/images/arts"
                        });
                });

            modelBuilder.Entity("FMA.Application.Entities.Expertise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DomainId")
                        .HasColumnType("integer");

                    b.Property<string>("ExpertiseName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DomainId");

                    b.ToTable("Expertises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DomainId = 1,
                            ExpertiseName = "Furniture assembler",
                            PhotoPath = "/"
                        },
                        new
                        {
                            Id = 2,
                            DomainId = 1,
                            ExpertiseName = "Chauffeur",
                            PhotoPath = "/"
                        },
                        new
                        {
                            Id = 3,
                            DomainId = 1,
                            ExpertiseName = "Painter",
                            PhotoPath = "/"
                        },
                        new
                        {
                            Id = 4,
                            DomainId = 1,
                            ExpertiseName = "Carpenter",
                            PhotoPath = "/"
                        },
                        new
                        {
                            Id = 5,
                            DomainId = 1,
                            ExpertiseName = "Roof repairer",
                            PhotoPath = "/"
                        },
                        new
                        {
                            Id = 6,
                            DomainId = 2,
                            ExpertiseName = "Housekeeper",
                            PhotoPath = "/"
                        },
                        new
                        {
                            Id = 7,
                            DomainId = 2,
                            ExpertiseName = "Housesitter",
                            PhotoPath = "/"
                        },
                        new
                        {
                            Id = 8,
                            DomainId = 2,
                            ExpertiseName = "Babysitter",
                            PhotoPath = "/"
                        },
                        new
                        {
                            Id = 9,
                            DomainId = 2,
                            ExpertiseName = "Nanny",
                            PhotoPath = "/"
                        },
                        new
                        {
                            Id = 10,
                            DomainId = 2,
                            ExpertiseName = "Caregiver",
                            PhotoPath = "/"
                        },
                        new
                        {
                            Id = 11,
                            DomainId = 2,
                            ExpertiseName = "Cook",
                            PhotoPath = "/"
                        },
                        new
                        {
                            Id = 12,
                            DomainId = 2,
                            ExpertiseName = "Kitchen cleaner",
                            PhotoPath = "/"
                        },
                        new
                        {
                            Id = 13,
                            DomainId = 2,
                            ExpertiseName = "Gardener",
                            PhotoPath = "/"
                        },
                        new
                        {
                            Id = 14,
                            DomainId = 2,
                            ExpertiseName = "Grocery shopper",
                            PhotoPath = "/"
                        },
                        new
                        {
                            Id = 31,
                            DomainId = 3,
                            ExpertiseName = "Dance teacher",
                            PhotoPath = "/"
                        });
                });

            modelBuilder.Entity("FMA.Application.Entities.Freelancer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateRegistered")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DomainId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("FulfilledContracts")
                        .HasColumnType("integer");

                    b.Property<decimal>("HourlyRate")
                        .HasColumnType("numeric");

                    b.Property<int>("HoursBilled")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Latitude")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Longitude")
                        .HasColumnType("numeric");

                    b.Property<int>("MainExpertiseId")
                        .HasColumnType("integer");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Rating")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("DomainId");

                    b.ToTable("Freelancers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateRegistered = new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc),
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
                            DateRegistered = new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Utc),
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
                            DateRegistered = new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Utc),
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
                            DateRegistered = new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Utc),
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
                            DateRegistered = new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc),
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
                            DateRegistered = new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Utc),
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
                            DateRegistered = new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Utc),
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
                            DateRegistered = new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc),
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
                            DateRegistered = new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Utc),
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
                            DateRegistered = new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Utc),
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
                            DateRegistered = new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Utc),
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

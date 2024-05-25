﻿// <auto-generated />
using System;
using FMA.Application.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FMA.Application.Migrations
{
    [DbContext(typeof(FreelancerContext))]
    [Migration("20240525083311_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
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

                    b.HasKey("Id");

                    b.HasIndex("DomainId");

                    b.ToTable("Expertises");
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
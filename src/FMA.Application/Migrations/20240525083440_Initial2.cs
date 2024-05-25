using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FMA.Application.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Domains",
                columns: new[] { "Id", "DomainName", "FontFamily", "PhotoPath" },
                values: new object[,]
                {
                    { 1, "Manual Labor", "Times New Roman", "/images/manuallabor" },
                    { 2, "Home Care", "Helvetica", "/images/homecare" },
                    { 3, "Health ", "Courier New", "/images/health" },
                    { 4, "White Collar Labor", "Verdana", "/images/whitecollar" },
                    { 5, "Home Repair", "Arial", "/images/homerepair" },
                    { 6, "Pet Care", "Century Gothic", "/images/petcare" },
                    { 7, "Creative", "Cambria", "/images/creative" }
                });

            migrationBuilder.InsertData(
                table: "Expertises",
                columns: new[] { "Id", "DomainId", "ExpertiseName" },
                values: new object[,]
                {
                    { 1, 1, "Furniture assembler" },
                    { 2, 1, "Chauffeur" },
                    { 3, 1, "Painter" },
                    { 4, 1, "Carpenter" },
                    { 5, 1, "Roof repairer" },
                    { 6, 2, "Housekeeper" },
                    { 7, 2, "Housesitter" },
                    { 8, 2, "Babysitter" },
                    { 9, 2, "Nanny" },
                    { 10, 2, "Caregiver" },
                    { 11, 2, "Cook" },
                    { 12, 2, "Kitchen cleaner" },
                    { 13, 2, "Gardener" },
                    { 14, 2, "Grocery shopper" },
                    { 31, 3, "Dance teacher" }
                });

            migrationBuilder.InsertData(
                table: "Freelancers",
                columns: new[] { "Id", "DateRegistered", "DomainId", "Email", "FirstName", "FulfilledContracts", "HourlyRate", "HoursBilled", "IsActive", "LastName", "Latitude", "Longitude", "PhoneNumber", "PhotoPath", "Rating" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Utc), 1, "nadia@example.com", "Nadia", 15, 55m, 300, true, "Al-Saud", 26.4207m, 50.0888m, "+966504567890", "/images/nadia.jpg", 4.7m },
                    { 2, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Utc), 1, "khalid@example.com", "Khalid", 18, 45m, 350, true, "Al-Farsi", 23.8859m, 45.0792m, "+966509876543", "/images/khalid.jpg", 4.6m },
                    { 3, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Utc), 1, "sara@example.com", "Sara", 30, 65m, 600, true, "Al-Qahtani", 24.7743m, 46.7384m, "+966501234567", "/images/sara.jpg", 4.9m },
                    { 4, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Utc), 1, "yousef@example.com", "Yousef", 22, 70m, 450, true, "Al-Ghamdi", 21.4858m, 39.1925m, "+966504321098", "/images/yousef.jpg", 4.5m },
                    { 5, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), 1, "layla@example.com", "Layla", 28, 55m, 550, true, "Al-Omari", 26.4207m, 50.0888m, "+966509876543", "/images/layla.jpg", 4.8m },
                    { 6, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), 2, "omar@example.com", "Omar", 19, 60m, 380, true, "Al-Zahrani", 23.8859m, 45.0792m, "+966501234567", "/images/omar.jpg", 4.7m },
                    { 7, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2, "huda@example.com", "Huda", 24, 65m, 500, true, "Al-Muhanna", 24.7743m, 46.7384m, "+966504567890", "/images/huda.jpg", 4.6m },
                    { 8, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), 2, "fahad@example.com", "Fahad", 32, 50m, 640, true, "Al-Rashidi", 24.7136m, 46.6753m, "+966501234567", "/images/fahad.jpg", 4.9m },
                    { 9, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Utc), 2, "amal@example.com", "Amal", 26, 55m, 520, true, "Al-Mutairi", 21.4858m, 39.1925m, "+966501111222", "/images/amal.jpg", 4.8m },
                    { 10, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Utc), 2, "abdullah@example.com", "Abdullah", 21, 70m, 420, true, "Al-Qassem", 26.4207m, 50.0888m, "+966509876543", "/images/abdullah.jpg", 4.7m },
                    { 11, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Utc), 2, "noura@example.com", "Noura", 29, 60m, 580, true, "Al-Sulaiman", 23.8859m, 45.0792m, "+966504321098", "/images/noura.jpg", 4.9m }
                });

            migrationBuilder.InsertData(
                table: "ExpertiseFreelancer",
                columns: new[] { "ExpertiseId", "FreelancerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExpertiseFreelancer",
                keyColumns: new[] { "ExpertiseId", "FreelancerId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ExpertiseFreelancer",
                keyColumns: new[] { "ExpertiseId", "FreelancerId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

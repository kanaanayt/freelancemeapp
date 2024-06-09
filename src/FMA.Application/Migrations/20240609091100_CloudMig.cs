using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FMA.Application.Migrations
{
    /// <inheritdoc />
    public partial class CloudMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Domains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DomainName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domains", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Expertises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DomainId = table.Column<int>(type: "int", nullable: false),
                    ExpertiseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expertises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Expertises_Domains_DomainId",
                        column: x => x.DomainId,
                        principalTable: "Domains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Freelancers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DomainId = table.Column<int>(type: "int", nullable: false),
                    MainExpertiseId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateRegistered = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HourlyRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FulfilledContracts = table.Column<int>(type: "int", nullable: false),
                    HoursBilled = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Freelancers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Freelancers_Domains_DomainId",
                        column: x => x.DomainId,
                        principalTable: "Domains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpertiseFreelancer",
                columns: table => new
                {
                    FreelancerId = table.Column<int>(type: "int", nullable: false),
                    ExpertiseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertiseFreelancer", x => new { x.FreelancerId, x.ExpertiseId });
                    table.ForeignKey(
                        name: "FK_ExpertiseFreelancer_Expertises_ExpertiseId",
                        column: x => x.ExpertiseId,
                        principalTable: "Expertises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ExpertiseFreelancer_Freelancers_FreelancerId",
                        column: x => x.FreelancerId,
                        principalTable: "Freelancers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Domains",
                columns: new[] { "Id", "DomainName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, "Manual Labor", "https://freelanceme.blob.core.windows.net/container1/manual_labor.png" },
                    { 2, "Domestic Services", "https://freelanceme.blob.core.windows.net/container1/domestic_services.png" },
                    { 3, "Health & Welness ", "https://freelanceme.blob.core.windows.net/container1/health_and_wellness.png" },
                    { 4, "Business Services", "https://freelanceme.blob.core.windows.net/container1/business_services.png" },
                    { 5, "Home Technology", "https://freelanceme.blob.core.windows.net/container1/home_technology.png" },
                    { 6, "Pet Care", "https://freelanceme.blob.core.windows.net/container1/pets.png" },
                    { 7, "Performing Arts", "https://freelanceme.blob.core.windows.net/container1/performing_arts.png" }
                });

            migrationBuilder.InsertData(
                table: "Expertises",
                columns: new[] { "Id", "DomainId", "ExpertiseName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, 1, "Furniture assembler", "/" },
                    { 2, 1, "Chauffeur", "/" },
                    { 3, 1, "Painter", "/" },
                    { 4, 1, "Carpenter", "/" },
                    { 5, 1, "Roof repairer", "/" },
                    { 6, 2, "Housekeeper", "/" },
                    { 7, 2, "Housesitter", "/" },
                    { 8, 2, "Babysitter", "/" },
                    { 9, 2, "Nanny", "/" },
                    { 10, 2, "Caregiver", "/" },
                    { 11, 2, "Cook", "/" },
                    { 12, 2, "Kitchen cleaner", "/" },
                    { 13, 2, "Gardener", "/" },
                    { 14, 2, "Grocery shopper", "/" },
                    { 31, 3, "Dance teacher", "/" }
                });

            migrationBuilder.InsertData(
                table: "Freelancers",
                columns: new[] { "Id", "DateRegistered", "DomainId", "Email", "FirstName", "FulfilledContracts", "HourlyRate", "HoursBilled", "IsActive", "LastName", "Latitude", "Longitude", "MainExpertiseId", "PhoneNumber", "PhotoPath", "Rating" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Utc), 1, "nadia@example.com", "Nadia", 15, 55m, 300, true, "Al-Saud", 26.4207m, 50.0888m, 3, "+966504567890", "/images/nadia.jpg", 4.7m },
                    { 2, new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Utc), 1, "khalid@example.com", "Khalid", 18, 45m, 350, true, "Al-Farsi", 23.8859m, 45.0792m, 2, "+966509876543", "/images/khalid.jpg", 4.6m },
                    { 3, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Utc), 1, "sara@example.com", "Sara", 30, 65m, 600, true, "Al-Qahtani", 24.7743m, 46.7384m, 2, "+966501234567", "/images/sara.jpg", 4.9m },
                    { 4, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Utc), 1, "yousef@example.com", "Yousef", 22, 70m, 450, true, "Al-Ghamdi", 21.4858m, 39.1925m, 4, "+966504321098", "/images/yousef.jpg", 4.5m },
                    { 5, new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1, "layla@example.com", "Layla", 28, 55m, 550, true, "Al-Omari", 26.4207m, 50.0888m, 1, "+966509876543", "/images/layla.jpg", 4.8m },
                    { 6, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Utc), 2, "omar@example.com", "Omar", 19, 60m, 380, true, "Al-Zahrani", 23.8859m, 45.0792m, 3, "+966501234567", "/images/omar.jpg", 4.7m },
                    { 7, new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), 2, "huda@example.com", "Huda", 24, 65m, 500, true, "Al-Muhanna", 24.7743m, 46.7384m, 3, "+966504567890", "/images/huda.jpg", 4.6m },
                    { 8, new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), 2, "fahad@example.com", "Fahad", 32, 50m, 640, true, "Al-Rashidi", 24.7136m, 46.6753m, 3, "+966501234567", "/images/fahad.jpg", 4.9m },
                    { 9, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Utc), 2, "amal@example.com", "Amal", 26, 55m, 520, true, "Al-Mutairi", 21.4858m, 39.1925m, 3, "+966501111222", "/images/amal.jpg", 4.8m },
                    { 10, new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Utc), 2, "abdullah@example.com", "Abdullah", 21, 70m, 420, true, "Al-Qassem", 26.4207m, 50.0888m, 3, "+966509876543", "/images/abdullah.jpg", 4.7m },
                    { 11, new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Utc), 2, "noura@example.com", "Noura", 29, 60m, 580, true, "Al-Sulaiman", 23.8859m, 45.0792m, 3, "+966504321098", "/images/noura.jpg", 4.9m }
                });

            migrationBuilder.InsertData(
                table: "ExpertiseFreelancer",
                columns: new[] { "ExpertiseId", "FreelancerId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 2, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 4 },
                    { 4, 4 },
                    { 1, 5 },
                    { 3, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpertiseFreelancer_ExpertiseId",
                table: "ExpertiseFreelancer",
                column: "ExpertiseId");

            migrationBuilder.CreateIndex(
                name: "IX_Expertises_DomainId",
                table: "Expertises",
                column: "DomainId");

            migrationBuilder.CreateIndex(
                name: "IX_Freelancers_DomainId",
                table: "Freelancers",
                column: "DomainId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpertiseFreelancer");

            migrationBuilder.DropTable(
                name: "Expertises");

            migrationBuilder.DropTable(
                name: "Freelancers");

            migrationBuilder.DropTable(
                name: "Domains");
        }
    }
}

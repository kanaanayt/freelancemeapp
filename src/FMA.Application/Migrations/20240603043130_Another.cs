using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FMA.Application.Migrations
{
    /// <inheritdoc />
    public partial class Another : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoPath",
                value: "/images/manual");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DomainName", "PhotoPath" },
                values: new object[] { "Domestic Services", "/images/domestic" });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 3,
                column: "DomainName",
                value: "Health & Welness ");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DomainName", "PhotoPath" },
                values: new object[] { "Business Services", "/images/business" });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DomainName", "PhotoPath" },
                values: new object[] { "Home Technology", "/images/hometech" });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DomainName", "PhotoPath" },
                values: new object[] { "Performing Arts", "/images/arts" });

            migrationBuilder.InsertData(
                table: "ExpertiseFreelancer",
                columns: new[] { "ExpertiseId", "FreelancerId" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 3, 5 }
                });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateRegistered",
                value: new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateRegistered",
                value: new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateRegistered",
                value: new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExpertiseFreelancer",
                keyColumns: new[] { "ExpertiseId", "FreelancerId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ExpertiseFreelancer",
                keyColumns: new[] { "ExpertiseId", "FreelancerId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoPath",
                value: "/images/manuallabor");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DomainName", "PhotoPath" },
                values: new object[] { "Home Care", "/images/homecare" });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 3,
                column: "DomainName",
                value: "Health ");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DomainName", "PhotoPath" },
                values: new object[] { "White Collar Labor", "/images/whitecollar" });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DomainName", "PhotoPath" },
                values: new object[] { "Home Repair", "/images/homerepair" });

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DomainName", "PhotoPath" },
                values: new object[] { "Creative", "/images/creative" });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateRegistered",
                value: new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateRegistered",
                value: new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateRegistered",
                value: new DateTime(2024, 2, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateRegistered",
                value: new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Utc));
        }
    }
}

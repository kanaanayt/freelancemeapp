using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FMA.Application.Migrations
{
    /// <inheritdoc />
    public partial class Mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "BorderColor",
                table: "Expertises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BorderColor", "PhotoPath" },
                values: new object[] { "#fdf1d3", "https://freelanceme.blob.core.windows.net/container1/furniture_assembler" });

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BorderColor", "PhotoPath" },
                values: new object[] { "#f3fee7", "https://freelanceme.blob.core.windows.net/container1/chauffeur" });

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BorderColor", "PhotoPath" },
                values: new object[] { "#fee7e7", "https://freelanceme.blob.core.windows.net/container1/painter" });

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BorderColor", "PhotoPath" },
                values: new object[] { "#e7edfe", "https://freelanceme.blob.core.windows.net/container1/carpenter" });

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BorderColor", "PhotoPath" },
                values: new object[] { "#ffeab5", "https://freelanceme.blob.core.windows.net/container1/roof_repairer" });

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BorderColor", "DomainId", "ExpertiseName", "PhotoPath" },
                values: new object[] { "#dcffb5", 1, "Packer", "https://freelanceme.blob.core.windows.net/container1/packing_service" });

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BorderColor", "DomainId", "ExpertiseName", "PhotoPath" },
                values: new object[] { "#fdf1d3", 1, "Window cleaner", "https://freelanceme.blob.core.windows.net/container1/window_cleaner" });

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BorderColor", "DomainId", "ExpertiseName", "PhotoPath" },
                values: new object[] { "#f3fee7", 1, "Yard worker", "https://freelanceme.blob.core.windows.net/container1/yard_worker" });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateRegistered",
                value: new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 8, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Utc));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BorderColor",
                table: "Expertises");

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoPath",
                value: "/");

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoPath",
                value: "/");

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoPath",
                value: "/");

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhotoPath",
                value: "/");

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhotoPath",
                value: "/");

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DomainId", "ExpertiseName", "PhotoPath" },
                values: new object[] { 2, "Housekeeper", "/" });

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DomainId", "ExpertiseName", "PhotoPath" },
                values: new object[] { 2, "Housesitter", "/" });

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DomainId", "ExpertiseName", "PhotoPath" },
                values: new object[] { 2, "Babysitter", "/" });

            migrationBuilder.InsertData(
                table: "Expertises",
                columns: new[] { "Id", "DomainId", "ExpertiseName", "PhotoPath" },
                values: new object[,]
                {
                    { 9, 2, "Nanny", "/" },
                    { 10, 2, "Caregiver", "/" },
                    { 11, 2, "Cook", "/" },
                    { 12, 2, "Kitchen cleaner", "/" },
                    { 13, 2, "Gardener", "/" },
                    { 14, 2, "Grocery shopper", "/" },
                    { 31, 3, "Dance teacher", "/" }
                });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateRegistered",
                value: new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Utc));
        }
    }
}

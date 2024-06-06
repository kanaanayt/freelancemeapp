using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FMA.Application.Migrations
{
    /// <inheritdoc />
    public partial class MainExpertises : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateRegistered", "MainExpertiseId" },
                values: new object[] { new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateRegistered", "MainExpertiseId" },
                values: new object[] { new DateTime(2024, 4, 21, 0, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateRegistered", "MainExpertiseId" },
                values: new object[] { new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateRegistered", "MainExpertiseId" },
                values: new object[] { new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc), 1 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateRegistered",
                value: new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Utc));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateRegistered", "MainExpertiseId" },
                values: new object[] { new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateRegistered", "MainExpertiseId" },
                values: new object[] { new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateRegistered", "MainExpertiseId" },
                values: new object[] { new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateRegistered", "MainExpertiseId" },
                values: new object[] { new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateRegistered",
                value: new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc));
        }
    }
}

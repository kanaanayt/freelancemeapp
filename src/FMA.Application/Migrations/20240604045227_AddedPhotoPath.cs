using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FMA.Application.Migrations
{
    /// <inheritdoc />
    public partial class AddedPhotoPath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MainExpertiseId",
                table: "Freelancers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "Expertises",
                type: "text",
                nullable: false,
                defaultValue: "");

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
                column: "PhotoPath",
                value: "/");

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 7,
                column: "PhotoPath",
                value: "/");

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 8,
                column: "PhotoPath",
                value: "/");

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 9,
                column: "PhotoPath",
                value: "/");

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 10,
                column: "PhotoPath",
                value: "/");

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 11,
                column: "PhotoPath",
                value: "/");

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 12,
                column: "PhotoPath",
                value: "/");

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 13,
                column: "PhotoPath",
                value: "/");

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 14,
                column: "PhotoPath",
                value: "/");

            migrationBuilder.UpdateData(
                table: "Expertises",
                keyColumn: "Id",
                keyValue: 31,
                column: "PhotoPath",
                value: "/");

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateRegistered", "MainExpertiseId" },
                values: new object[] { new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), 3 });

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
                columns: new[] { "DateRegistered", "MainExpertiseId" },
                values: new object[] { new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateRegistered", "MainExpertiseId" },
                values: new object[] { new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateRegistered", "MainExpertiseId" },
                values: new object[] { new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateRegistered", "MainExpertiseId" },
                values: new object[] { new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateRegistered", "MainExpertiseId" },
                values: new object[] { new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateRegistered", "MainExpertiseId" },
                values: new object[] { new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc), 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainExpertiseId",
                table: "Freelancers");

            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "Expertises");

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
    }
}

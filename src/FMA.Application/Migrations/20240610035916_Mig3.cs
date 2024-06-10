using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FMA.Application.Migrations
{
    /// <inheritdoc />
    public partial class Mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BorderColor",
                table: "Domains",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 1,
                column: "BorderColor",
                value: "#fdf1d3");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 2,
                column: "BorderColor",
                value: "#f3fee7");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 3,
                column: "BorderColor",
                value: "#fee7e7");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 4,
                column: "BorderColor",
                value: "#e7edfe");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 5,
                column: "BorderColor",
                value: "#ffeab5");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 6,
                column: "BorderColor",
                value: "#dcffb5");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 7,
                column: "BorderColor",
                value: "#fdf1d3");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BorderColor",
                table: "Domains");

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateRegistered",
                value: new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateRegistered",
                value: new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 6, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateRegistered",
                value: new DateTime(2024, 3, 21, 0, 0, 0, 0, DateTimeKind.Utc));
        }
    }
}

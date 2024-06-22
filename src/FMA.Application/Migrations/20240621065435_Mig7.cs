using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FMA.Application.Migrations
{
    /// <inheritdoc />
    public partial class Mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Rating",
                table: "Freelancers",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "Freelancers",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "Freelancers",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<double>(
                name: "HourlyRate",
                table: "Freelancers",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Utc), 55.0, 26.4207, 50.088799999999999, 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 3, 23, 0, 0, 0, 0, DateTimeKind.Utc), 45.0, 23.885899999999999, 45.0792, 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Utc), 65.0, 24.7743, 46.738399999999999, 4.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Utc), 70.0, 21.485800000000001, 39.192500000000003, 4.5 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 3, 13, 0, 0, 0, 0, DateTimeKind.Utc), 55.0, 26.4207, 50.088799999999999, 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Utc), 60.0, 23.885899999999999, 45.0792, 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc), 65.0, 24.7743, 46.738399999999999, 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc), 50.0, 24.7136, 46.6753, 4.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 3, 3, 0, 0, 0, 0, DateTimeKind.Utc), 55.0, 21.485800000000001, 39.192500000000003, 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Utc), 70.0, 26.4207, 50.088799999999999, 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Utc), 60.0, 23.885899999999999, 45.0792, 4.9000000000000004 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Freelancers",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Freelancers",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Freelancers",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<decimal>(
                name: "HourlyRate",
                table: "Freelancers",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Utc), 55m, 26.4207m, 50.0888m, 4.7m });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Utc), 45m, 23.8859m, 45.0792m, 4.6m });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Utc), 65m, 24.7743m, 46.7384m, 4.9m });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc), 70m, 21.4858m, 39.1925m, 4.5m });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 3, 4, 0, 0, 0, 0, DateTimeKind.Utc), 55m, 26.4207m, 50.0888m, 4.8m });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Utc), 60m, 23.8859m, 45.0792m, 4.7m });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Utc), 65m, 24.7743m, 46.7384m, 4.6m });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Utc), 50m, 24.7136m, 46.6753m, 4.9m });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Utc), 55m, 21.4858m, 39.1925m, 4.8m });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 3, 9, 0, 0, 0, 0, DateTimeKind.Utc), 70m, 26.4207m, 50.0888m, 4.7m });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateRegistered", "HourlyRate", "Latitude", "Longitude", "Rating" },
                values: new object[] { new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Utc), 60m, 23.8859m, 45.0792m, 4.9m });
        }
    }
}

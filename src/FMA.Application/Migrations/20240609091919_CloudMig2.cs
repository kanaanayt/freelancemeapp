using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FMA.Application.Migrations
{
    /// <inheritdoc />
    public partial class CloudMig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoPath",
                value: "https://freelanceme.blob.core.windows.net/container1/manual_labor");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoPath",
                value: "https://freelanceme.blob.core.windows.net/container1/domestic_services");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoPath",
                value: "https://freelanceme.blob.core.windows.net/container1/health_and_wellness");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhotoPath",
                value: "https://freelanceme.blob.core.windows.net/container1/business_services");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhotoPath",
                value: "https://freelanceme.blob.core.windows.net/container1/home_technology");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 6,
                column: "PhotoPath",
                value: "https://freelanceme.blob.core.windows.net/container1/pets");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 7,
                column: "PhotoPath",
                value: "https://freelanceme.blob.core.windows.net/container1/performing_arts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhotoPath",
                value: "https://freelanceme.blob.core.windows.net/container1/manual_labor.png");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhotoPath",
                value: "https://freelanceme.blob.core.windows.net/container1/domestic_services.png");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhotoPath",
                value: "https://freelanceme.blob.core.windows.net/container1/health_and_wellness.png");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhotoPath",
                value: "https://freelanceme.blob.core.windows.net/container1/business_services.png");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhotoPath",
                value: "https://freelanceme.blob.core.windows.net/container1/home_technology.png");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 6,
                column: "PhotoPath",
                value: "https://freelanceme.blob.core.windows.net/container1/pets.png");

            migrationBuilder.UpdateData(
                table: "Domains",
                keyColumn: "Id",
                keyValue: 7,
                column: "PhotoPath",
                value: "https://freelanceme.blob.core.windows.net/container1/performing_arts.png");
        }
    }
}

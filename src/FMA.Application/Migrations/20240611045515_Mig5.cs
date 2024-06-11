using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FMA.Application.Migrations
{
    /// <inheritdoc />
    public partial class Mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExpertiseFreelancer",
                keyColumns: new[] { "ExpertiseId", "FreelancerId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ExpertiseFreelancer",
                keyColumns: new[] { "ExpertiseId", "FreelancerId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ExpertiseFreelancer",
                keyColumns: new[] { "ExpertiseId", "FreelancerId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "ExpertiseFreelancer",
                keyColumns: new[] { "ExpertiseId", "FreelancerId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "ExpertiseFreelancer",
                keyColumns: new[] { "ExpertiseId", "FreelancerId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ExpertiseFreelancer",
                keyColumns: new[] { "ExpertiseId", "FreelancerId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.InsertData(
                table: "ExpertiseFreelancer",
                columns: new[] { "ExpertiseId", "FreelancerId" },
                values: new object[,]
                {
                    { 4, 1 },
                    { 3, 3 },
                    { 1, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 3, 7 },
                    { 7, 7 },
                    { 8, 8 }
                });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1,
                column: "MainExpertiseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 3,
                column: "MainExpertiseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 5,
                column: "MainExpertiseId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DomainId", "MainExpertiseId" },
                values: new object[] { 1, 6 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DomainId", "MainExpertiseId" },
                values: new object[] { 1, 7 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DomainId", "MainExpertiseId" },
                values: new object[] { 1, 8 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DomainId", "MainExpertiseId" },
                values: new object[] { 1, 8 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DomainId", "MainExpertiseId" },
                values: new object[] { 1, 8 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DomainId", "MainExpertiseId" },
                values: new object[] { 1, 8 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExpertiseFreelancer",
                keyColumns: new[] { "ExpertiseId", "FreelancerId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ExpertiseFreelancer",
                keyColumns: new[] { "ExpertiseId", "FreelancerId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ExpertiseFreelancer",
                keyColumns: new[] { "ExpertiseId", "FreelancerId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ExpertiseFreelancer",
                keyColumns: new[] { "ExpertiseId", "FreelancerId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "ExpertiseFreelancer",
                keyColumns: new[] { "ExpertiseId", "FreelancerId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "ExpertiseFreelancer",
                keyColumns: new[] { "ExpertiseId", "FreelancerId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ExpertiseFreelancer",
                keyColumns: new[] { "ExpertiseId", "FreelancerId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "ExpertiseFreelancer",
                keyColumns: new[] { "ExpertiseId", "FreelancerId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.InsertData(
                table: "ExpertiseFreelancer",
                columns: new[] { "ExpertiseId", "FreelancerId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 3, 5 }
                });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 1,
                column: "MainExpertiseId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 3,
                column: "MainExpertiseId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 5,
                column: "MainExpertiseId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DomainId", "MainExpertiseId" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DomainId", "MainExpertiseId" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DomainId", "MainExpertiseId" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DomainId", "MainExpertiseId" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DomainId", "MainExpertiseId" },
                values: new object[] { 2, 3 });

            migrationBuilder.UpdateData(
                table: "Freelancers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DomainId", "MainExpertiseId" },
                values: new object[] { 2, 3 });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Corporate_training_management_system.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Ahmedabad", "IT" },
                    { 2, "Ahmedabad", "HR" }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "ExpertiesLevel", "Name" },
                values: new object[] { 1, "[\".NET\",\"C#\"]", "Akshay" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "Email", "Name" },
                values: new object[,]
                {
                    { 1, 1, "crunal@company.com", "Krunal" },
                    { 2, 2, "charvin@company.com", "Charvin" }
                });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "DurationInDays", "StartDate", "Title", "TrainerId" },
                values: new object[] { 1, 20, new DateOnly(2026, 2, 22), ".NET", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

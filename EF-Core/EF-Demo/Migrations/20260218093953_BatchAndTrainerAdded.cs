using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_Demo.Migrations
{
    /// <inheritdoc />
    public partial class BatchAndTrainerAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    StudentsId = table.Column<int>(type: "int", nullable: false),
                    coursesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.StudentsId, x.coursesId });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Courses_coursesId",
                        column: x => x.coursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ExperienceYears = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Batches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Batches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Batches_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Batches_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "ExperienceYears", "Name" },
                values: new object[,]
                {
                    { 1, 3, "Jay" },
                    { 2, 4, "Rohit" }
                });

            migrationBuilder.InsertData(
                table: "Batches",
                columns: new[] { "Id", "CourseId", "StartDate", "TrainerId" },
                values: new object[,]
                {
                    { 1, 1, new DateOnly(2026, 3, 1), 1 },
                    { 2, 1, new DateOnly(2026, 4, 1), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Batches_CourseId",
                table: "Batches",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Batches_TrainerId",
                table: "Batches",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_coursesId",
                table: "CourseStudent",
                column: "coursesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Batches");

            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.DropTable(
                name: "Trainers");
        }
    }
}

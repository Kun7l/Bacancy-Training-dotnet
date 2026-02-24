using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Corporate_training_management_system.Migrations
{
    /// <inheritdoc />
    public partial class joinTableAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTrainingProgram_Employees_EmployeeId",
                table: "EmployeeTrainingProgram");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTrainingProgram_TrainingPrograms_TrainingProgramId",
                table: "EmployeeTrainingProgram");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeTrainingProgram",
                table: "EmployeeTrainingProgram");

            migrationBuilder.RenameTable(
                name: "EmployeeTrainingProgram",
                newName: "EmployeeTrainingPrograms");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeTrainingProgram_TrainingProgramId",
                table: "EmployeeTrainingPrograms",
                newName: "IX_EmployeeTrainingPrograms_TrainingProgramId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeTrainingPrograms",
                table: "EmployeeTrainingPrograms",
                columns: new[] { "EmployeeId", "TrainingProgramId" });

            migrationBuilder.UpdateData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateOnly(2026, 2, 23));

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTrainingPrograms_Employees_EmployeeId",
                table: "EmployeeTrainingPrograms",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTrainingPrograms_TrainingPrograms_TrainingProgramId",
                table: "EmployeeTrainingPrograms",
                column: "TrainingProgramId",
                principalTable: "TrainingPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTrainingPrograms_Employees_EmployeeId",
                table: "EmployeeTrainingPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTrainingPrograms_TrainingPrograms_TrainingProgramId",
                table: "EmployeeTrainingPrograms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeTrainingPrograms",
                table: "EmployeeTrainingPrograms");

            migrationBuilder.RenameTable(
                name: "EmployeeTrainingPrograms",
                newName: "EmployeeTrainingProgram");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeTrainingPrograms_TrainingProgramId",
                table: "EmployeeTrainingProgram",
                newName: "IX_EmployeeTrainingProgram_TrainingProgramId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeTrainingProgram",
                table: "EmployeeTrainingProgram",
                columns: new[] { "EmployeeId", "TrainingProgramId" });

            migrationBuilder.UpdateData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateOnly(2026, 2, 22));

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTrainingProgram_Employees_EmployeeId",
                table: "EmployeeTrainingProgram",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTrainingProgram_TrainingPrograms_TrainingProgramId",
                table: "EmployeeTrainingProgram",
                column: "TrainingProgramId",
                principalTable: "TrainingPrograms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_School_Project.Migrations
{
    /// <inheritdoc />
    public partial class NewCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalYearsWorked",
                table: "Employees");

            migrationBuilder.AddColumn<DateOnly>(
                name: "StartedWorkYear",
                table: "Employees",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartedWorkYear",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "TotalYearsWorked",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

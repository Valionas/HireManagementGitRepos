using Microsoft.EntityFrameworkCore.Migrations;

namespace HireManagement.Migrations
{
    public partial class ContractAndWorkerUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployedOnPosition",
                table: "Worker",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Worker",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployerEmail",
                table: "Contract",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployedOnPosition",
                table: "Worker");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Worker");

            migrationBuilder.DropColumn(
                name: "EmployerEmail",
                table: "Contract");
        }
    }
}

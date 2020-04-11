using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HireManagement.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    ContractID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractName = table.Column<string>(nullable: true),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    Reward = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.ContractID);
                });

            migrationBuilder.CreateTable(
                name: "Worker",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    JoinedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Worker", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Recruitment",
                columns: table => new
                {
                    RecruitmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractID = table.Column<int>(nullable: false),
                    WorkerID = table.Column<int>(nullable: false),
                    Review = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recruitment", x => x.RecruitmentID);
                    table.ForeignKey(
                        name: "FK_Recruitment_Contract_ContractID",
                        column: x => x.ContractID,
                        principalTable: "Contract",
                        principalColumn: "ContractID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recruitment_Worker_WorkerID",
                        column: x => x.WorkerID,
                        principalTable: "Worker",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recruitment_ContractID",
                table: "Recruitment",
                column: "ContractID");

            migrationBuilder.CreateIndex(
                name: "IX_Recruitment_WorkerID",
                table: "Recruitment",
                column: "WorkerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recruitment");

            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "Worker");
        }
    }
}

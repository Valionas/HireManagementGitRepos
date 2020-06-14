using Microsoft.EntityFrameworkCore.Migrations;

namespace HireManagement.Migrations
{
    public partial class ContractUltraUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recruitment");

            migrationBuilder.AddColumn<string>(
                name: "Information",
                table: "Contract",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Preference",
                table: "Contract",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Information",
                table: "Contract");

            migrationBuilder.DropColumn(
                name: "Preference",
                table: "Contract");

            migrationBuilder.CreateTable(
                name: "Recruitment",
                columns: table => new
                {
                    RecruitmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractID = table.Column<int>(type: "int", nullable: false),
                    Review = table.Column<int>(type: "int", nullable: true),
                    WorkerID = table.Column<int>(type: "int", nullable: false)
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
                        principalColumn: "WorkerID",
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
    }
}

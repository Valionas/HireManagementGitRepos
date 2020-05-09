using Microsoft.EntityFrameworkCore.Migrations;

namespace HireManagement.Migrations
{
    public partial class ExtendUserNickname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserNickName",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserNickName",
                table: "AspNetUsers");
        }
    }
}

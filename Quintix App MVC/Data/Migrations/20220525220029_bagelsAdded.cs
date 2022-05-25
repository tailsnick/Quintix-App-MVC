using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quintix_App_MVC.Data.Migrations
{
    public partial class bagelsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bagels",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bagels",
                table: "AspNetUsers");
        }
    }
}

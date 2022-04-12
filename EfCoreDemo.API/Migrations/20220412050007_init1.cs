using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EfCoreDemo.API.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Department");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Department",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

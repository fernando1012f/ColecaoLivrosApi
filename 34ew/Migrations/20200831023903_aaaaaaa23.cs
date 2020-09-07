using Microsoft.EntityFrameworkCore.Migrations;

namespace _34ew.Migrations
{
    public partial class aaaaaaa23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AutorId1",
                table: "Livros");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

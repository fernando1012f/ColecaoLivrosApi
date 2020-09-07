using Microsoft.EntityFrameworkCore.Migrations;

namespace _34ew.Migrations
{
    public partial class newColumnAutorIdade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Idade",
                table: "Autores",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Idade",
                table: "Autores");
        }
    }
}

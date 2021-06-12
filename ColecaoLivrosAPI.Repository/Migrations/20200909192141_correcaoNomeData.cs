using Microsoft.EntityFrameworkCore.Migrations;

namespace _34ew.Migrations
{
    public partial class correcaoNomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataDeNascimento",
                table: "Autores",
                newName: "DataNascimento");

            migrationBuilder.RenameColumn(
                name: "DataDeFalecimento",
                table: "Autores",
                newName: "DataFalecimento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "Autores",
                newName: "DataDeNascimento");

            migrationBuilder.RenameColumn(
                name: "DataFalecimento",
                table: "Autores",
                newName: "DataDeFalecimento");
        }
    }
}

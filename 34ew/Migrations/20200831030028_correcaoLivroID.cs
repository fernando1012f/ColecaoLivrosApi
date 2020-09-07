﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace _34ew.Migrations
{
    public partial class correcaoLivroID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autores_AutorId1",
                table: "Livros");

            migrationBuilder.DropIndex(
                name: "IX_Livros_AutorId1",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "AutorId1",
                table: "Livros");

            migrationBuilder.AlterColumn<long>(
                name: "AutorId",
                table: "Livros",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Livros_AutorId",
                table: "Livros",
                column: "AutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autores_AutorId",
                table: "Livros",
                column: "AutorId",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livros_Autores_AutorId",
                table: "Livros");

            migrationBuilder.DropIndex(
                name: "IX_Livros_AutorId",
                table: "Livros");

            migrationBuilder.AlterColumn<int>(
                name: "AutorId",
                table: "Livros",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "AutorId1",
                table: "Livros",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Livros_AutorId1",
                table: "Livros",
                column: "AutorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Livros_Autores_AutorId1",
                table: "Livros",
                column: "AutorId1",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

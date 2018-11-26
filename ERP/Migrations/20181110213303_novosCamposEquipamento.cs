using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ERP.Migrations
{
    public partial class novosCamposEquipamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Caid",
                table: "Equipamentos",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnderecoInstalacao",
                table: "Equipamentos",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomeUsuario",
                table: "Equipamentos",
                type: "varchar(30)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnderecoInstalacao",
                table: "Equipamentos");

            migrationBuilder.DropColumn(
                name: "NomeUsuario",
                table: "Equipamentos");

            migrationBuilder.AlterColumn<string>(
                name: "Caid",
                table: "Equipamentos",
                type: "varchar(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

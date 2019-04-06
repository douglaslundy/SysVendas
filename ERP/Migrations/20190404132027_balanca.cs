using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ERP.Migrations
{
    public partial class balanca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Balancas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DigitoInicial = table.Column<int>(nullable: false),
                    FimCodigo = table.Column<int>(nullable: false),
                    FimValor = table.Column<int>(nullable: false),
                    InicioCodigo = table.Column<int>(nullable: false),
                    InicioValor = table.Column<int>(nullable: false),
                    Tamanho = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balancas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Balancas");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ERP.Migrations
{
    public partial class sysvendas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Chave",
                table: "Sysvendas",
                nullable: true,
                oldClrType: typeof(Guid));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "Chave",
                table: "Sysvendas",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

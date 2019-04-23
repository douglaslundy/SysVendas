using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ERP.Migrations
{
    public partial class start : Migration
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

            migrationBuilder.CreateTable(
                name: "Equipamentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    Caid = table.Column<string>(nullable: true),
                    Cartao = table.Column<string>(type: "varchar(30)", nullable: true),
                    ClienteId = table.Column<int>(nullable: true),
                    EnderecoInstalacao = table.Column<string>(type: "varchar(100)", nullable: true),
                    NomeUsuario = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodigoProduto = table.Column<string>(nullable: true),
                    Estoque = table.Column<decimal>(type: "decimal(10, 3)", nullable: false),
                    NomeProduto = table.Column<string>(nullable: true),
                    PrecoPago = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    PrecoVenda = table.Column<decimal>(type: "decimal(10, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sysvendas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Chave = table.Column<string>(nullable: true),
                    DataAtivacao = table.Column<DateTime>(nullable: false),
                    DataExpira = table.Column<DateTime>(nullable: false),
                    Dias = table.Column<int>(nullable: false),
                    DisponivelParaAtivar = table.Column<int>(nullable: false),
                    DisponivelParaUtilizar = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sysvendas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Endereco = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(30)", nullable: false),
                    SobreNome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Ddd = table.Column<string>(type: "varchar(3)", nullable: false),
                    Numero = table.Column<string>(type: "varchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carrinhos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NumeroItem = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false),
                    Quantidade = table.Column<decimal>(type: "decimal(10, 3)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "decimal(10, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinhos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carrinhos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Carrinhos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Endereco = table.Column<string>(nullable: true),
                    Identidade = table.Column<string>(nullable: true),
                    Inadimplente = table.Column<bool>(nullable: false),
                    Limite = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    Observacao = table.Column<string>(nullable: true),
                    SaldoDebitos = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: false),
                    NumeroCpf = table.Column<string>(type: "varchar(15)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(30)", nullable: false),
                    SobreNome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Ddd = table.Column<string>(type: "varchar(3)", nullable: false),
                    NumeroTelefone = table.Column<string>(type: "varchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(nullable: true),
                    CodigoVenda = table.Column<Guid>(nullable: false),
                    DataPagamento = table.Column<DateTime>(nullable: false),
                    DataVencimento = table.Column<DateTime>(nullable: false),
                    DataVenda = table.Column<DateTime>(nullable: false),
                    Desconto = table.Column<decimal>(nullable: false),
                    PagamentoCartaoCredito = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    PagamentoCartaoDebito = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    PagamentoCheque = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    PagamentoDinheiro = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    PagamentoRealizado = table.Column<int>(nullable: false),
                    TipoVenda = table.Column<int>(nullable: false),
                    TotalPago = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    TotalVenda = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    Troco = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vendas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItensVendas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodigoVenda = table.Column<Guid>(nullable: false),
                    NumeroItem = table.Column<int>(nullable: false),
                    PrecoProduto = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    ProdutoId = table.Column<int>(nullable: false),
                    Quantidade = table.Column<decimal>(type: "decimal(10, 3)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    VendaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensVendas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItensVendas_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItensVendas_Vendas_VendaId",
                        column: x => x.VendaId,
                        principalTable: "Vendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carrinhos_ProdutoId",
                table: "Carrinhos",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinhos_UsuarioId",
                table: "Carrinhos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_UsuarioId",
                table: "Clientes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensVendas_ProdutoId",
                table: "ItensVendas",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensVendas_VendaId",
                table: "ItensVendas",
                column: "VendaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ClienteId",
                table: "Vendas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_UsuarioId",
                table: "Vendas",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Balancas");

            migrationBuilder.DropTable(
                name: "Carrinhos");

            migrationBuilder.DropTable(
                name: "Equipamentos");

            migrationBuilder.DropTable(
                name: "ItensVendas");

            migrationBuilder.DropTable(
                name: "Sysvendas");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}

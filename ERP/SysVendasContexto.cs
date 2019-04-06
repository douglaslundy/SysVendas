using ERP.Carrinhos;
using ERP.Clientes;
using ERP.Equipamentos;
using ERP.ItensVendas;
using ERP.ObjetosValor;
using ERP.Produtos;
using ERP.SysVendas;
using ERP.Usuarios;
using ERP.Vendas;
using ERP.Balancas;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ERP
{
    public class SysVendasContexto : DbContext
    {
        public DbSet<SysVenda> Sysvendas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItensVenda> ItensVendas { get; set; }
        public DbSet<Carrinho> Carrinhos { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<Balanca> Balancas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // esse foreach anula oncascade em todos os relacionaments 
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<Cliente>()
            .OwnsOne<NomeCompleto>(s => s.NomeCompleto, cb =>
            {
                cb.Property(c => c.Nome)
                    .HasColumnName("Nome")
                    .HasColumnType("varchar(30)")
                    .IsRequired();

                cb.Property(c => c.Sobrenome)
                    .HasColumnName("SobreNome")
                    .HasColumnType("varchar(50)")
                    .IsRequired();
            });

            modelBuilder.Entity<Cliente>()
            .OwnsOne<Telefone>(s => s.Telefone, cb =>
            {
                cb.Property(c => c.Ddd)
                    .HasColumnName("Ddd")
                    .HasColumnType("varchar(3)")
                    .IsRequired();

                cb.Property(c => c.Numero)
                    .HasColumnName("NumeroTelefone")
                    .HasColumnType("varchar(15)")
                    .IsRequired();
            });

            modelBuilder.Entity<Cliente>()
            .OwnsOne<CPF>(s => s.Cpf, cb =>
            {
                cb.Property(c => c.Numero)
                    .HasColumnName("NumeroCpf")
                    .HasColumnType("varchar(15)")
                    .IsRequired();
            });


            modelBuilder.Entity<Usuario>()
            .OwnsOne<NomeCompleto>(s => s.NomeCompleto, cb =>
            {
                cb.Property(c => c.Nome)
                    .HasColumnName("Nome")
                    .HasColumnType("varchar(30)")
                    .IsRequired();

                cb.Property(c => c.Sobrenome)
                    .HasColumnName("SobreNome")
                    .HasColumnType("varchar(50)")
                    .IsRequired();
            });

            modelBuilder.Entity<Usuario>()
            .OwnsOne<Telefone>(s => s.Telefone, cb =>
            {
                cb.Property(c => c.Ddd)
                    .HasColumnName("Ddd")
                    .HasColumnType("varchar(3)")
                    .IsRequired();

                cb.Property(c => c.Numero)
                    .HasColumnName("Numero")
                    .HasColumnType("varchar(15)")
                    .IsRequired();
            });


            modelBuilder.Entity<Produto>(eb =>
            {
                eb.Property(b => b.PrecoPago).HasColumnType("decimal(10, 2)");
                eb.Property(b => b.PrecoVenda).HasColumnType("decimal(10, 2)");
                eb.Property(b => b.Estoque).HasColumnType("decimal(10, 3)");
            });

            modelBuilder.Entity<Venda>(eb =>
            {
                eb.Property(b => b.TotalPago).HasColumnType("decimal(10, 2)");
                eb.Property(b => b.TotalVenda).HasColumnType("decimal(10, 2)");
                eb.Property(b => b.Troco).HasColumnType("decimal(10, 2)");
                eb.Property(b => b.PagamentoDinheiro).HasColumnType("decimal(10, 2)");
                eb.Property(b => b.PagamentoCheque).HasColumnType("decimal(10, 2)");
                eb.Property(b => b.PagamentoCartaoCredito).HasColumnType("decimal(10, 2)");
                eb.Property(b => b.PagamentoCartaoDebito).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<Carrinho>(eb =>
            {
                eb.Property(b => b.SubTotal).HasColumnType("decimal(10, 2)");
                eb.Property(b => b.ValorUnitario).HasColumnType("decimal(10, 2)");
                eb.Property(b => b.Quantidade).HasColumnType("decimal(10, 3)");
            });


            modelBuilder.Entity<ItensVenda>(eb =>
            {
                eb.Property(b => b.SubTotal).HasColumnType("decimal(10, 2)");
                eb.Property(b => b.PrecoProduto).HasColumnType("decimal(10, 2)");
                eb.Property(b => b.Quantidade).HasColumnType("decimal(10, 3)");
            });


            modelBuilder.Entity<Cliente>(eb =>
            {
                eb.Property(b => b.Limite).HasColumnType("decimal(10, 2)");
                eb.Property(b => b.SaldoDebitos).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<Equipamento>(eb =>
            {
                eb.Property(b => b.NomeUsuario).HasColumnType("varchar(30)");
                eb.Property(b => b.EnderecoInstalacao).HasColumnType("varchar(100)");
                eb.Property(b => b.Cartao).HasColumnType("varchar(30)");
                eb.Property(b => b.Cartao).HasColumnType("varchar(30)");
            });

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(Conexao.ConnectionString);
            optionsBuilder.UseMySql(Conexao.ConnectionString);
        }
    }
}

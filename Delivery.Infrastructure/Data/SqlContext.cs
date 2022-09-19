using Delivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Infrastructure.Data
{
  public class SqlContext : DbContext
  {
    public SqlContext() { }
    public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Fornecedor> Fornecedores { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<ItemProduto> ItensProdutos { get; set; }
    public DbSet<Venda> Vendas { get; set; }
  }
}
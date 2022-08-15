using Delivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Infrastructure.Data
{
  // Db context  rastreia as alterações feitas em entidades. Essas entidades rastreadas, por sua vez,
  // conduzem as alterações no banco de dados quando Save Changes é chamado.
  public class SqlContext : DbContext
  {
    public SqlContext() { }

    public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

    public DbSet<Cliente> Clientes { get; set; }

    public DbSet<Usuario> Usuarios { get; set; }

    public DbSet<Endereco> Enderecos { get; set; }

    public DbSet<Fornecedor> Fornecedores { get; set; }
    
    public DbSet<Produto> Produtos { get; set; }
  }
}
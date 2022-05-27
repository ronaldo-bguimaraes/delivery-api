using Delivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;
using EntityState = Microsoft.EntityFrameworkCore.EntityState;

namespace Delivery.Infrastructure.Data
{
  // Db context  rastreia as alterações feitas em entidades. Essas entidades rastreadas, por sua vez, 
  // conduzem as alterações no banco de dados quando Save Changes é chamado. 
  public class SqlContext : DbContext
  {
    public SqlContext() { }

    public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

    public Microsoft.EntityFrameworkCore.DbSet<Cliente> Clientes { get; set; }
    public Microsoft.EntityFrameworkCore.DbSet<Usuario> Usuarios { get; set; }

    // Esse método chamará automaticamente DetectChanges()
    // para descobrir quaisquer alterações em instâncias de entidade antes de salvar no banco de dados subjacente.
    public override int SaveChanges()
    {
      foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
      {
        if (entry.State == EntityState.Added)
        {
          entry.Property("DataCadastro").CurrentValue = DateTime.Now;

        }

        if (entry.State == EntityState.Modified)
        {
          entry.Property("DataCadastro").IsModified = false;

        }
      }

      return base.SaveChanges();
    }

  }
}
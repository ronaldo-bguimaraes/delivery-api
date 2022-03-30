using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;
using EntityState = Microsoft.EntityFrameworkCore.EntityState;

namespace RestAPiModeloDDD.Infrastructure.Data
{
    public class SqlContext : DbContext
    // Db context  rastreia as alterações feitas em entidades.Essas entidades rastreadas, por sua vez, 
    //conduzem as alterações no banco de dados quando Save Changes é chamado. 

    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public Microsoft.EntityFrameworkCore.DbSet<Cliente> clientes { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Produto> produtos { get; set; }

        public override int SaveChanges() // Esse método chamará automaticamente DetectChanges()
                                          // para descobrir quaisquer alterações em instâncias de entidade antes de salvar no banco de dados subjacente.
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;

                }

                if(entry.State == EntityState.Modified){
                    entry.Property("DataCadastro").IsModified = false;
                    
                }
            }


            return base.SaveChanges();
        }

    }
}


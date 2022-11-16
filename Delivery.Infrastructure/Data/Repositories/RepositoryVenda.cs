using System;
using System.Collections.Generic;
using System.Linq;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Infrastructure.Data.Repositories
{
  public class RepositoryVenda : RepositoryBase<Venda>, IRepositoryVenda
  {
    private readonly SqlContext SqlContext;
    public RepositoryVenda(SqlContext sqlcontext) : base(sqlcontext)
    {
      SqlContext = sqlcontext;
    }

    public ICollection<Venda> GetByClienteId(int id)
    {
      return SqlContext.Set<Venda>()
        .Include(e => e.ItensProduto)
        .Include(e => e.Pagamentos)
        .Where(e => e.ClienteId == id).ToList();
    }

    public override void Update(Venda venda)
    {
      var entity = SqlContext.Set<Venda>().Find(venda.Id);
      SqlContext.Entry(entity).CurrentValues.SetValues(venda);
      SqlContext.Entry(entity).Property(e => e.DataVenda).IsModified = false;
      SqlContext.SaveChanges();
    }
  }
}

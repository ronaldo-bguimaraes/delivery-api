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
    private readonly SqlContext sqlContext;
    public RepositoryVenda(SqlContext _sqlcontext) : base(_sqlcontext)
    {
      sqlContext = _sqlcontext;
    }

    public ICollection<Venda> GetByClienteId(int clienteId)
    {
      return sqlContext.Set<Venda>().Include(e => e.ItensProduto).Where(e => e.ClienteId == clienteId).ToList();
    }

    public override void Update(Venda venda)
    {
      var entity = sqlContext.Set<Venda>().Find(venda.Id);
      sqlContext.Entry(entity).CurrentValues.SetValues(venda);
      sqlContext.Entry(entity).Property(x => x.DataVenda).IsModified = false;
      sqlContext.SaveChanges();
    }
  }
}

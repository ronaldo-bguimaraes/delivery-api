using System;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;

namespace Delivery.Infrastructure.Data.Repositories
{
  public class RepositoryVenda : RepositoryBase<Venda>, IRepositoryVenda
  {
    private readonly SqlContext sqlContext;
    public RepositoryVenda(SqlContext _sqlcontext) : base(_sqlcontext)
    {
      sqlContext = _sqlcontext;
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

using System;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;

namespace Delivery.Infrastructure.Data.Repositories
{
  public class RepositoryPagamento : RepositoryBase<Pagamento>, IRepositoryPagamento
  {
    private readonly SqlContext SqlContext;
    public RepositoryPagamento(SqlContext sqlcontext) : base(sqlcontext)
    {
      SqlContext = sqlcontext;
    }

    public override void Update(Pagamento pagamento)
    {
      var entity = SqlContext.Set<Pagamento>().Find(pagamento.Id);
      SqlContext.Entry(entity).CurrentValues.SetValues(pagamento);
      SqlContext.Entry(entity).Property(e => e.DataPagamento).IsModified = false;
      SqlContext.SaveChanges();
    }
  }
}

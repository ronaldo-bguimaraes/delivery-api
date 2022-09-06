using System;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;

namespace Delivery.Infrastructure.Data.Repositories
{
  public class RepositoryPagamento : RepositoryBase<Pagamento>, IRepositoryPagamento
  {
    private readonly SqlContext sqlContext;
    public RepositoryPagamento(SqlContext _sqlcontext) : base(_sqlcontext)
    {
      sqlContext = _sqlcontext;
    }

    public override void Update(Pagamento pagamento)
    {
      var entity = sqlContext.Set<Pagamento>().Find(pagamento.Id);
      sqlContext.Entry(entity).CurrentValues.SetValues(pagamento);
      sqlContext.Entry(entity).Property(x => x.DataPagamento).IsModified = false;
      sqlContext.SaveChanges();
    }
  }
}

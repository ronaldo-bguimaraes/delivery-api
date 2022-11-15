using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;

namespace Delivery.Infrastructure.Data.Repositories
{
  public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
  {
    private readonly SqlContext SqlContext;

    public RepositoryProduto(SqlContext sqlcontext) : base(sqlcontext)
    {
      SqlContext = sqlcontext;
    }
  }
}

using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;

namespace Delivery.Infrastructure.Data.Repositories
{
  public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
  {
    private readonly SqlContext sqlContext;
    public RepositoryProduto(SqlContext _sqlcontext) : base(_sqlcontext)
    {
      sqlContext = _sqlcontext;
    }
  }
}

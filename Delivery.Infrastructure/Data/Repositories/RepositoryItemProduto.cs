using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;

namespace Delivery.Infrastructure.Data.Repositories
{
  public class RepositoryItemProduto : RepositoryBase<ItemProduto>, IRepositoryItemProduto
  {
    private readonly SqlContext sqlContext;

    public RepositoryItemProduto(SqlContext _sqlcontext) : base(_sqlcontext)
    {
      sqlContext = _sqlcontext;
    }
  }
}

using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;

namespace Delivery.Infrastructure.Data.Repositories
{
  public class RepositoryItemProduto : RepositoryBase<ItemProduto>, IRepositoryItemProduto
  {
    private readonly SqlContext SqlContext;

    public RepositoryItemProduto(SqlContext sqlcontext) : base(sqlcontext)
    {
      SqlContext = sqlcontext;
    }
  }
}

using System.Collections.Generic;
using System.Linq;
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

    public ICollection<Produto> GetByFornecedorId(int id)
    {
      return SqlContext.Set<Produto>()
        .Where(e => e.FornecedorId == id).ToList();
    }
  }
}

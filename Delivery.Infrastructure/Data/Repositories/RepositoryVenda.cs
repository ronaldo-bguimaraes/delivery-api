using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Infrastructure.Data.Repositories
{
  public class RepositoryVenda : RepositoryBase<Venda>, IRepositoryVenda
  {
    private readonly SqlContext sqlContext;
    public RepositoryVenda(SqlContext _sqlcontext) : base(_sqlcontext)
    {
      sqlContext = _sqlcontext;
    }


    }
}

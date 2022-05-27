using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;

namespace Delivery.Infrastructure.Data.Repositories
{
  public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
  {
    private readonly SqlContext sqlContext;
    public RepositoryCliente(SqlContext _sqlcontext) : base(_sqlcontext)
    {
      sqlContext = _sqlcontext;
    }
  }
}

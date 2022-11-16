using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;
using System.Linq;

namespace Delivery.Infrastructure.Data.Repositories
{
  public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
  {
    private readonly SqlContext SqlContext;

    public RepositoryCliente(SqlContext sqlcontext) : base(sqlcontext)
    {
      SqlContext = sqlcontext;
    }

    public Cliente GetByUsuarioId(int id)
    {
      return SqlContext.Set<Cliente>().Where(e => e.UsuarioId == id).FirstOrDefault();
    }
  }
}

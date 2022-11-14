using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;
using System.Linq;

namespace Delivery.Infrastructure.Data.Repositories
{
  public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
  {
    private readonly SqlContext sqlContext;

    public RepositoryCliente(SqlContext _sqlcontext) : base(_sqlcontext)
    {
      sqlContext = _sqlcontext;
    }

    public Cliente GetByUsuarioId(int usuarioId)
    {
      return All().Where(c => c.UsuarioId == usuarioId).FirstOrDefault();
    }
  }
}

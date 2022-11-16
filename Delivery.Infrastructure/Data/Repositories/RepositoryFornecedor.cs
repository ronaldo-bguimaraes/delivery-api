using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;
using System.Linq;

namespace Delivery.Infrastructure.Data.Repositories
{
  public class RepositoryFornecedor : RepositoryBase<Fornecedor>, IRepositoryFornecedor
  {
    private readonly SqlContext SqlContext;

    public RepositoryFornecedor(SqlContext sqlcontext) : base(sqlcontext)
    {
      SqlContext = sqlcontext;
    }

    public Fornecedor GetByUsuarioId(int id)
    {
      return SqlContext.Set<Fornecedor>().Where(e => e.UsuarioId == id).FirstOrDefault();
    }
  }
}

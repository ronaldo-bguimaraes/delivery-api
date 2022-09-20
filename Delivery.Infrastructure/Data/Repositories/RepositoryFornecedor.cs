using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;
using System.Linq;

namespace Delivery.Infrastructure.Data.Repositories
{
  public class RepositoryFornecedor : RepositoryBase<Fornecedor>, IRepositoryFornecedor
  {
    private readonly SqlContext sqlContext;

    public RepositoryFornecedor(SqlContext _sqlcontext) : base(_sqlcontext)
    {
      sqlContext = _sqlcontext;
    }

    public Fornecedor GetByUsuarioId(int usuarioId)
    {
      return sqlContext.Set<Fornecedor>().Where(c => c.UsuarioId == usuarioId).FirstOrDefault();
    }
  }
}

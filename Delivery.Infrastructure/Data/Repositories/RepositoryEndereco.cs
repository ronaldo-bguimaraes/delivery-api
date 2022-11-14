using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Infrastructure.Data.Repositories
{
  public class RepositoryEndereco : RepositoryBase<Endereco>, IRepositoryEndereco
  {
    private readonly SqlContext sqlContext;

    public RepositoryEndereco(SqlContext _sqlcontext) : base(_sqlcontext)
    {
      sqlContext = _sqlcontext;
    }

    public ICollection<Endereco> GetByUsuarioId(int usuarioId)
    {
      return sqlContext.Set<Endereco>().Where(e => e.UsuarioId == usuarioId).ToList();
    }
  }
}

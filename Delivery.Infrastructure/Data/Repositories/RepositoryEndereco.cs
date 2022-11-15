using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Infrastructure.Data.Repositories
{
  public class RepositoryEndereco : RepositoryBase<Endereco>, IRepositoryEndereco
  {
    private readonly SqlContext SqlContext;

    public RepositoryEndereco(SqlContext sqlcontext) : base(sqlcontext)
    {
      SqlContext = sqlcontext;
    }

    public ICollection<Endereco> GetByUsuarioId(int id)
    {
      return SqlContext.Set<Endereco>().Where(e => e.UsuarioId == id).ToList();
    }
  }
}

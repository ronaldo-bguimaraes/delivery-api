using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Delivery.Infrastructure.Data.Repositories
{
  public class RepositoryUsuario : RepositoryBase<Usuario>, IRepositoryUsuario
  {
    private readonly SqlContext sqlContext;

    public RepositoryUsuario(SqlContext _sqlcontext) : base(_sqlcontext)
    {
      sqlContext = _sqlcontext;
    }

    public override void Update(Usuario usuario)
    {
      sqlContext.Set<Usuario>().Update(usuario);
      sqlContext.Entry(usuario).Property(x => x.DataCadastro).IsModified = false;
      sqlContext.SaveChanges();
    }
  }
}

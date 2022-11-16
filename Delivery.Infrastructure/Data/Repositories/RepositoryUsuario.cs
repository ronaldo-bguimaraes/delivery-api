using System.Linq;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;

namespace Delivery.Infrastructure.Data.Repositories
{
  public class RepositoryUsuario : RepositoryBase<Usuario>, IRepositoryUsuario
  {
    private readonly SqlContext SqlContext;

    public RepositoryUsuario(SqlContext sqlcontext) : base(sqlcontext)
    {
      SqlContext = sqlcontext;
    }

    public override void Update(Usuario usuario)
    {
      var entity = SqlContext.Set<Usuario>().Find(usuario.Id);
      SqlContext.Entry(entity).CurrentValues.SetValues(usuario);
      SqlContext.Entry(entity).Property(e => e.DataCadastro).IsModified = false;
      SqlContext.SaveChanges();
    }

    public Usuario GetByEmail(string email)
    {
      return SqlContext.Set<Usuario>().Where(e => e.Email == email).FirstOrDefault();
    }

    public Usuario GetByTelefone(string telefone)
    {
      return SqlContext.Set<Usuario>().Where(e => e.Telefone == telefone).FirstOrDefault();
    }
  }
}

using System.Linq;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;

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
      var entity = sqlContext.Set<Usuario>().Find(usuario.Id);
      sqlContext.Entry(entity).CurrentValues.SetValues(usuario);
      sqlContext.Entry(entity).Property(x => x.DataCadastro).IsModified = false;
      sqlContext.SaveChanges();
    }

    public Usuario GetByEmail(string email)
    {
      return sqlContext.Set<Usuario>().Where(e => e.Email == email).FirstOrDefault();
    }

    public Usuario GetByTelefone(string telefone)
    {
      return sqlContext.Set<Usuario>().Where(e => e.Telefone == telefone).FirstOrDefault();
    }
  }
}

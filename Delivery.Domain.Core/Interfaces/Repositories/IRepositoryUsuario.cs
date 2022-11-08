using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Repositories
{
  public interface IRepositoryUsuario : IRepositoryBase<Usuario>
  {
    public Usuario GetByEmailAndSenha(string email, string senha);
    public Usuario GetByTelefoneAndSenha(string telefone, string senha);
  }
}

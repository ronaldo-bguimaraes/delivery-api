using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Services
{
  public interface IServiceUsuario : IServiceBase<Usuario>
  {
    public Usuario GetByEmailAndSenha(string email, string senha);
    public Usuario GetByTelefoneAndSenha(string telefone, string senha);
  }
}

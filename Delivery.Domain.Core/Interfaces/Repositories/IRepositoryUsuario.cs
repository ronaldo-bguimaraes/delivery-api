using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Repositories
{
  public interface IRepositoryUsuario : IRepositoryBase<Usuario>
  {
    public Usuario GetByEmail(string email);
    public Usuario GetByTelefone(string telefone);
  }
}

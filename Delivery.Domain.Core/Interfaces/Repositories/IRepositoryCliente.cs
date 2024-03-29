using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Repositories
{
  public interface IRepositoryCliente : IRepositoryBase<Cliente>
  {
    public Cliente GetByUsuarioId(int usuarioId);
  }
}

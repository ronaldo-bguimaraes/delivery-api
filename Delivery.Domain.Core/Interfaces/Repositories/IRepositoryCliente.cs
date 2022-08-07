using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Repositories
{
  public interface IRepositoryCliente : IRepositoryBase<Cliente>
  {
    Cliente GetByUsuarioId(int usuarioId);
  }
}

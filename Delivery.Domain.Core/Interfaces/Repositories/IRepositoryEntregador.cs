using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Repositories
{
  public interface IRepositoryEntregador : IRepositoryBase<Entregador>
  {
    Entregador GetByUsuarioId(int usuarioId);
  }
}

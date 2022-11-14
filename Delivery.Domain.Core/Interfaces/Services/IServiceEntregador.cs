using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Services
{
  public interface IServiceEntregador : IServiceBase<Entregador>
  {
    Entregador GetByUsuarioId(int usuarioId);
  }
}

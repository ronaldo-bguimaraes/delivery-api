using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Services
{
  public interface IServiceCliente : IServiceBase<Cliente>
  {
    Cliente GetByUsuarioId(int usuarioId);
  }
}

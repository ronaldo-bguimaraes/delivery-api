using Delivery.Application.Dtos;

namespace Delivery.Application
{
  public interface IApplicationServiceCliente : IApplicationServiceBase<ClienteDto>
  {
    public ClienteDto GetByUsuarioId(int id);
  }
}

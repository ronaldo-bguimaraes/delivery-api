using Delivery.Application.Dtos;

namespace Delivery.Application
{
  public interface IApplicationServiceEntregador : IApplicationServiceBase<EntregadorDto>
  {
    public EntregadorDto GetByUsuarioId(int id);
  }
}

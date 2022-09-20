using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Services
{
  public interface IServiceFornecedor : IServiceBase<Fornecedor>
  {
    Fornecedor GetByUsuarioId(int usuarioId);
  }
}

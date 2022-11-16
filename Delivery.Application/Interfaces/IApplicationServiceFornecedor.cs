using Delivery.Application.Dtos;

namespace Delivery.Application
{
  public interface IApplicationServiceFornecedor : IApplicationServiceBase<FornecedorDto>
  {
    public FornecedorDto GetByUsuarioId(int id);
  }
}

using Delivery.Domain.Entities;
using Delivery.Application.Dtos;

namespace Delivery.Application.Interfaces.Mappers
{
  public interface IMapperPagamento : IMapperBase<PagamentoDto, Pagamento> { }
}

using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Infrastructure.CrossCutting.Interface
{
  public interface IMapperPagamento //MapeamentoDTO para entidade
  {
    Pagamento MapperDtoToEntity(PagamentoDto pagamentodto);
    IEnumerable<PagamentoDto> MapperEntitiesToDtos(IEnumerable<Pagamento> pagamentos);
    PagamentoDto MapperEntityToDto(Pagamento pagamento);
  }
}

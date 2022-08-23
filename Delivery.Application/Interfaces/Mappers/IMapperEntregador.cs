using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Infrastructure.CrossCutting.Interface
{
  public interface IMapperEntregador //MapeamentoDTO para entidade
  {
    Entregador MapperDtoToEntity(EntregadorDto entregadordto);
    IEnumerable<EntregadorDto> MapperEntitiesToDtos(IEnumerable<Entregador> entregadores);
    EntregadorDto MapperEntityToDto(Entregador entregador);
  }
}

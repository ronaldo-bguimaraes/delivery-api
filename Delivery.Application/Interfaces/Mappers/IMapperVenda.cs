using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Infrastructure.CrossCutting.Interface
{
  public interface IMapperVenda //MapeamentoDTO para entidade
  {
    Venda MapperDtoToEntity(VendaDto Vendadto);
    IEnumerable<VendaDto> MapperEntitiesToDtos(IEnumerable<Venda> vendas);
    VendaDto MapperEntityToDto(Venda venda);
  }
}

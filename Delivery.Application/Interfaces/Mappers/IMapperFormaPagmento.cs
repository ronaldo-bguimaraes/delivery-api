using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Infrastructure.CrossCutting.Interface
{
  public interface IMapperFormaPagamento //MapeamentoDTO para entidade
  {
    FormaPagamento MapperDtoToEntity(FormaPagamentoDto clientedto);
    IEnumerable<FormaPagamentoDto> MapperEntitiesToDtos(IEnumerable<FormaPagamento> formaPagamento);
    FormaPagamentoDto MapperEntityToDto(FormaPagamento formaPagamento);
  }
}

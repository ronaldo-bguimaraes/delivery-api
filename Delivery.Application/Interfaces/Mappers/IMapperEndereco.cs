using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Infrastructure.CrossCutting.Interface
{
  public interface IMapperEndereco //MapeamentoDTO para entidade
  {
    Endereco MapperDtoToEntity(EnderecoDto enderecodto);
    IEnumerable<EnderecoDto> MapperEntitiesToDtos(IEnumerable<Endereco> endereco);
    EnderecoDto MapperEntityToDto(Endereco endereco);
  }
}

using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Infrastructure.CrossCutting.Interface
{
  public interface IMapperEndereco //MapeamentoDTO para entidade
  {
    Endereco MapperDtoToEntity(EnderecoDto enderecoDto);
    IEnumerable<EnderecoDto> MapperEntitiesToDtos(IEnumerable<Endereco> enderecos);
    EnderecoDto MapperEntityToDto(Endereco endereco);
  }
}

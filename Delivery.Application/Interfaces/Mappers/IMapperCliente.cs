using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Infrastructure.CrossCutting.Interface
{
  public interface IMapperCliente //MapeamentoDTO para entidade
  {
    Cliente MapperDtoToEntity(ClienteDto clienteDto);
    IEnumerable<ClienteDto> MapperEntitiesToDtos(IEnumerable<Cliente> clientes);
    ClienteDto MapperEntityToDto(Cliente cliente);
  }
}

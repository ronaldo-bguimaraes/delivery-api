using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Infrastructure.CrossCutting.Interface
{
  public interface IMapperCliente //MapeamentoDTO para entidade
  {
    Cliente MapperDtoToEntity(ClienteDto clientedto);
    IEnumerable<ClienteDto> MapperlistClientesDto(IEnumerable<Cliente> clientes);
    ClienteDto MapperEntityToDto(Cliente cliente);
  }
}

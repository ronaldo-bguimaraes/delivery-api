using RestApiModeloDDD.Domain.Entities;
using RestApiModeloDDD.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPiModeloDDD.Infrastructure.CrossCutting.Interface
{
   public interface IMapperCliente //MapeamentoDTO para entidade
    {
        Cliente MapperDtoToEntity(ClienteDto clientedto);
        IEnumerable<ClienteDto> MapperlistClientesDto(IEnumerable<Cliente> clientes);
        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}

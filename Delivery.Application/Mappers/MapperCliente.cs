using Delivery.Domain.Entities;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Infrastructure.CrossCutting.Map
{
  public class MapperCliente : IMapperCliente
  {
    public Cliente MapperDtoToEntity(ClienteDto clienteDto)
    {
      var cliente = new Cliente
      {
        ClienteId = clienteDto.Id,
        Cpf = clienteDto.Cpf,
        DataNascimento = clienteDto.DataNascimento,
        UsuarioId = clienteDto.UsuarioId,
      };
      return cliente;
    }

    public ClienteDto MapperEntityToDto(Cliente cliente)
    {
      var clienteDto = new ClienteDto
      {
        Id = cliente.ClienteId,
        Cpf = cliente.Cpf,
        DataNascimento = cliente.DataNascimento,
        UsuarioId = cliente.UsuarioId,
      };
      return clienteDto;
    }

    public IEnumerable<ClienteDto> MapperEntitiesToDtos(IEnumerable<Cliente> clientes)
    {
      var clienteDtos = clientes.Select(clienteDto => new ClienteDto
      {
        Id = clienteDto.ClienteId,
        Cpf = clienteDto.Cpf,
        DataNascimento = clienteDto.DataNascimento,
        UsuarioId = clienteDto.UsuarioId,
      });
      return clienteDtos;
    }

    public IEnumerable<Cliente> MapperDtosToEntities(IEnumerable<ClienteDto> clienteDtos)
    {
      var clientes = clienteDtos.Select(cliente => new Cliente
      {
        ClienteId = cliente.Id,
        Cpf = cliente.Cpf,
        DataNascimento = cliente.DataNascimento,
        UsuarioId = cliente.UsuarioId,
      });
      return clientes;
    }
  }
}

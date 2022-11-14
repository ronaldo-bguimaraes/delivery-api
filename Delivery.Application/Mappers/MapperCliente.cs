using Delivery.Domain.Entities;
using Delivery.Application.Dtos;
using System.Collections.Generic;
using System.Linq;
using Delivery.Application.Interfaces.Mappers;

namespace Delivery.Infrastructure.CrossCutting.Map
{
  public class MapperCliente : IMapperCliente
  {
    public Cliente MapperDtoToEntity(ClienteDto clienteDto)
    {
      var cliente = new Cliente()
      {
        Id = clienteDto.Id,
        Cpf = clienteDto.Cpf,
        DataNascimento = clienteDto.DataNascimento.ToUniversalTime(),
        UsuarioId = clienteDto.UsuarioId,
      };
      return cliente;
    }

    public ClienteDto MapperEntityToDto(Cliente cliente)
    {
      var clienteDto = new ClienteDto
      {
        Id = cliente.Id,
        Cpf = cliente.Cpf,
        DataNascimento = cliente.DataNascimento.ToUniversalTime(),
        UsuarioId = cliente.UsuarioId,
      };
      return clienteDto;
    }

    public ICollection<ClienteDto> MapperEntitiesToDtos(ICollection<Cliente> clientes)
    {
      var clienteDtos = clientes.Select(cliente => new ClienteDto
      {
        Id = cliente.Id,
        Cpf = cliente.Cpf,
        DataNascimento = cliente.DataNascimento.ToUniversalTime(),
        UsuarioId = cliente.UsuarioId,
      });
      return clienteDtos.ToList();
    }

    public ICollection<Cliente> MapperDtosToEntities(ICollection<ClienteDto> clienteDtos)
    {
      var clientes = clienteDtos.Select(clienteDto => new Cliente
      {
        Id = clienteDto.Id,
        Cpf = clienteDto.Cpf,
        DataNascimento = clienteDto.DataNascimento,
        UsuarioId = clienteDto.UsuarioId,
      });
      return clientes.ToList();
    }
  }
}

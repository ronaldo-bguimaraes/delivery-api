using Delivery.Domain.Entities;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Infrastructure.CrossCutting.Map
{
  public class MapperCliente : IMapperCliente
  {
    private readonly IMapperUsuario mapperUsuario;
    public MapperCliente(IMapperUsuario _mapperUsuario)
    {
      mapperUsuario = _mapperUsuario;
    }
    public Cliente MapperDtoToEntity(ClienteDto clientedto)
    {
      var cliente = new Cliente
      {
        Id = clientedto.Id,
        Cpf = clientedto.Cpf,
        DataNascimento = clientedto.DataNascimento,
        Usuario = mapperUsuario.MapperDtoToEntity(clientedto.Usuario)
      };
      return cliente;
    }

    public ClienteDto MapperEntityToDto(Cliente cliente)
    {
      var clienteDto = new ClienteDto
      {
        Id = cliente.Id,
        Cpf = cliente.Cpf,
        DataNascimento = cliente.DataNascimento,
        Usuario = mapperUsuario.MapperEntityToDto(cliente.Usuario)

      };
      return clienteDto;
    }

    public IEnumerable<ClienteDto> MapperEntitiesToDtos(IEnumerable<Cliente> clientes)
    {
      var clienteDtos = clientes.Select(clienteDto => new ClienteDto
      {
        Id = clienteDto.Id,
        Cpf = clienteDto.Cpf,
        DataNascimento = clienteDto.DataNascimento,
        Usuario = mapperUsuario.MapperEntityToDto(clienteDto.Usuario)
      });
      return clienteDtos;
    }

    public IEnumerable<Cliente> MapperDtosToEntities(IEnumerable<ClienteDto> clienteDtos)
    {
      var clientes = clienteDtos.Select(cliente => new Cliente
      {
        Id = cliente.Id,
        Cpf = cliente.Cpf,
        DataNascimento = cliente.DataNascimento,
        Usuario = mapperUsuario.MapperDtoToEntity(cliente.Usuario)
      });
      return clientes;
    }
  }
}

﻿using Delivery.Domain.Entities;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Infrastructure.CrossCutting.Map
{
  public class MapperCliente : IMapperCliente
  {
    public Cliente MapperDtoToEntity(ClienteDto clientedto)
    {
      var cliente = new Cliente()
      {
        Id = clientedto.Id,
        Nome = clientedto.Nome,
        Sobrenome = clientedto.Sobrenome,
        Email = clientedto.Email,
      };
      return cliente;
    }

    public ClienteDto MapperEntityToDto(Cliente cliente)
    {
      var clienteDto = new ClienteDto()
      {
        Id = cliente.Id,
        Nome = cliente.Nome,
        Sobrenome = cliente.Sobrenome,
        Email = cliente.Email,
      };
      return clienteDto;
    }

    public IEnumerable<ClienteDto> MapperlistClientesDto(IEnumerable<Cliente> clientes)
    {
      var dto = clientes.Select(c => new ClienteDto
      {
        Id = c.Id,
        Nome = c.Nome,
        Sobrenome = c.Sobrenome,
        Email = c.Email
      });
      return dto;
    }
  }
}

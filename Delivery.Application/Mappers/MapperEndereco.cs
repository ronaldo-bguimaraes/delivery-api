using Delivery.Domain.Entities;
using Delivery.Application.Dtos;
using System.Collections.Generic;
using System.Linq;
using Delivery.Application.Interfaces.Mappers;

namespace Delivery.Infrastructure.CrossCutting.Map
{
  public class MapperEndereco : IMapperEndereco
  {
    public Endereco MapperDtoToEntity(EnderecoDto enderecoDto)
    {
      var endereco = new Endereco
      {
        Id = enderecoDto.Id,
        Nome = enderecoDto.Nome,
        Apelido = enderecoDto.Apelido,
        Complemento = enderecoDto.Complemento,
        Descricao = enderecoDto.Descricao,
        Latitude = enderecoDto.Latitude,
        Longitude = enderecoDto.Longitude,
        UsuarioId = enderecoDto.UsuarioId,

      };
      return endereco;
    }

    public EnderecoDto MapperEntityToDto(Endereco endereco)
    {
      var enderecoDto = new EnderecoDto
      {
        Id = endereco.Id,
        Nome = endereco.Nome,
        Apelido = endereco.Apelido,
        Complemento = endereco.Complemento,
        Descricao = endereco.Descricao,
        Latitude = endereco.Latitude,
        Longitude = endereco.Longitude,
        UsuarioId = endereco.UsuarioId,
      };
      return enderecoDto;
    }

    public ICollection<EnderecoDto> MapperEntitiesToDtos(ICollection<Endereco> enderecos)
    {
      var enderecoDtos = enderecos.Select(endereco => new EnderecoDto
      {
        Id = endereco.Id,
        Nome = endereco.Nome,
        Apelido = endereco.Apelido,
        Complemento = endereco.Complemento,
        Descricao = endereco.Descricao,
        Latitude = endereco.Latitude,
        Longitude = endereco.Longitude,
        UsuarioId = endereco.UsuarioId,
      });
      return enderecoDtos.ToList();
    }

    public ICollection<Endereco> MapperDtosToEntities(ICollection<EnderecoDto> enderecoDtos)
    {
      var enderecos = enderecoDtos.Select(enderecoDto => new Endereco
      {
        Id = enderecoDto.Id,
        Nome = enderecoDto.Nome,
        Apelido = enderecoDto.Apelido,
        Complemento = enderecoDto.Complemento,
        Descricao = enderecoDto.Descricao,
        Latitude = enderecoDto.Latitude,
        Longitude = enderecoDto.Longitude,
        UsuarioId = enderecoDto.UsuarioId,
      });
      return enderecos.ToList();
    }
  }
}

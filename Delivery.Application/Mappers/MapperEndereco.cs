using Delivery.Domain.Entities;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using System.Collections.Generic;
using System.Linq;

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

    public IEnumerable<EnderecoDto> MapperEntitiesToDtos(IEnumerable<Endereco> enderecos)
    {
      var enderecoDtos = enderecos.Select(enderecoDto => new EnderecoDto
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
      return enderecoDtos;
    }

    public IEnumerable<Endereco> MapperDtosToEntities(IEnumerable<EnderecoDto> enderecoDtos)
    {
      var enderecos = enderecoDtos.Select(endereco => new Endereco
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
      return enderecos;
    }
  }
}

using Delivery.Domain.Entities;
using Delivery.Application.Dtos;
using System.Collections.Generic;
using System.Linq;
using Delivery.Application.Interfaces.Mappers;
using Delivery.Application;

namespace Delivery.Infrastructure.CrossCutting.Map
{
  public class MapperUsuario : IMapperUsuario
  {
    public Usuario MapperDtoToEntity(UsuarioDto usuarioDto)
    {
      var usuario = new Usuario
      {
        Id = usuarioDto.Id,
        Nome = usuarioDto.Nome,
        Telefone = usuarioDto.Telefone,
        Email = usuarioDto.Email,
        Senha = Security.CreateMD5Hash(usuarioDto.Senha),
      };
      return usuario;
    }

    public UsuarioDto MapperEntityToDto(Usuario usuario)
    {
      var usuarioDto = new UsuarioDto
      {
        Id = usuario.Id,
        Nome = usuario.Nome,
        Telefone = usuario.Telefone,
        Email = usuario.Email,
        DataCadastro = usuario.DataCadastro.ToUniversalTime(),
      };
      return usuarioDto;
    }

    public ICollection<UsuarioDto> MapperEntitiesToDtos(ICollection<Usuario> usuarios)
    {
      var usuarioDtos = usuarios.Select(usuario => new UsuarioDto
      {
        Id = usuario.Id,
        Nome = usuario.Nome,
        Telefone = usuario.Telefone,
        Email = usuario.Email,
        DataCadastro = usuario.DataCadastro.ToUniversalTime(),
      });
      return usuarioDtos.ToList();
    }

    public ICollection<Usuario> MapperDtosToEntities(ICollection<UsuarioDto> usuarioDtos)
    {
      var usuarios = usuarioDtos.Select(usuarioDto => new Usuario
      {
        Id = usuarioDto.Id,
        Nome = usuarioDto.Nome,
        Telefone = usuarioDto.Telefone,
        Email = usuarioDto.Email,
        Senha = Security.CreateMD5Hash(usuarioDto.Senha),
      });
      return usuarios.ToList();
    }
  }
}

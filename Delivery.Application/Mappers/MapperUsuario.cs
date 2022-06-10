using Delivery.Domain.Entities;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using System.Collections.Generic;
using System.Linq;

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
        Senha = usuarioDto.Senha,
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
      };
      return usuarioDto;
    }

    public IEnumerable<UsuarioDto> MapperEntitiesToDtos(IEnumerable<Usuario> usuarios)
    {
      var usuarioDtos = usuarios.Select(usuario => new UsuarioDto
      {
        Id = usuario.Id,
        Nome = usuario.Nome,
        Telefone = usuario.Telefone,
        Email = usuario.Email,
      });
      return usuarioDtos;
    }

    public IEnumerable<Usuario> MapperDtosToEntities(IEnumerable<UsuarioDto> usuarioDtos)
    {
      var usuarios = usuarioDtos.Select(usuarioDto => new Usuario
      {
        Id = usuarioDto.Id,
        Nome = usuarioDto.Nome,
        Telefone = usuarioDto.Telefone,
        Email = usuarioDto.Email,
        Senha = usuarioDto.Senha,
      });
      return usuarios;
    }

  }
}

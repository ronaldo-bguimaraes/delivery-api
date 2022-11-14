using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;
using Delivery.Application.Dtos;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Delivery.Application.Interfaces.Mappers;

namespace Delivery.Application
{
  public class ApplicationServiceUsuario : IApplicationServiceUsuario
  {
    private readonly IServiceUsuario serviceUsuario;
    private readonly IMapperUsuario mapperUsuario;

    public ApplicationServiceUsuario(IServiceUsuario _serviceUsuario, IMapperUsuario _mapperUsuario)
    {
      serviceUsuario = _serviceUsuario;
      mapperUsuario = _mapperUsuario;
    }

    public void Save(UsuarioDto usuarioDto)
    {
      var usuario = mapperUsuario.MapperDtoToEntity(usuarioDto);
      if (serviceUsuario.GetById(usuario.Id) == null)
      {
        serviceUsuario.Add(usuario);
      }
      else
      {
        serviceUsuario.Update(usuario);
      }
    }

    public ICollection<UsuarioDto> GetAll()
    {
      var usuario = serviceUsuario.All();
      return mapperUsuario.MapperEntitiesToDtos(usuario);
    }

    public UsuarioDto GetById(int id)
    {
      var usuario = serviceUsuario.GetById(id);
      return mapperUsuario.MapperEntityToDto(usuario);
    }

    public void Remove(UsuarioDto usuarioDto)
    {
      var usuario = mapperUsuario.MapperDtoToEntity(usuarioDto);
      serviceUsuario.Remove(usuario);
    }

    public Usuario GetUsuarioWithClaim(UsuarioDto usuarioDto)
    {
      Usuario usuario = null;
      if (usuarioDto.Telefone != null && usuario == null)
      {
        usuario = serviceUsuario.GetByTelefoneAndSenha(usuarioDto.Telefone, usuarioDto.Senha);
        if (usuario != null)
        {
          usuario.Claim = new Claim(ClaimTypes.MobilePhone, usuario.Telefone);
        }
      }
      if (usuarioDto.Email != null && usuario == null)
      {
        usuario = serviceUsuario.GetByEmailAndSenha(usuarioDto.Email, usuarioDto.Senha);
        if (usuario != null)
        {
          usuario.Claim = new Claim(ClaimTypes.Email, usuario.Email);
        }
      }
      return usuario;
    }

    public UsuarioDto Authenticate(UsuarioDto usuarioDto)
    {
      var usuario = GetUsuarioWithClaim(usuarioDto);

      if (usuario == null)
      {
        return null;
      }

      var key = Encoding.ASCII.GetBytes(Settings.Secret);

      var tokenDescriptor = new SecurityTokenDescriptor
      {
        Subject = new ClaimsIdentity(new Claim[] { usuario.Claim, new Claim("Store", "User") }),
        Expires = DateTime.UtcNow.AddDays(7),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      };

      var tokenHandler = new JwtSecurityTokenHandler();
      var token = tokenHandler.CreateToken(tokenDescriptor);

      var userDto = mapperUsuario.MapperEntityToDto(usuario);

      userDto.Token = tokenHandler.WriteToken(token);

      return userDto;
    }
  }
}

using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Delivery.Application.Mappers
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

    public void Add(UsuarioDto usuarioDto)
    {
      var Usuario = mapperUsuario.MapperDtoToEntity(usuarioDto);
      serviceUsuario.Add(Usuario);
    }

    public IEnumerable<UsuarioDto> GetAll()
    {
      var usuario = serviceUsuario.GetAll();
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

    public void Update(UsuarioDto usuarioDto)
    {
      var usuario = mapperUsuario.MapperDtoToEntity(usuarioDto);
      serviceUsuario.Update(usuario);
    }

    public UsuarioDto Authenticate(UsuarioDto usuarioDto)
    {
      var user = serviceUsuario.GetAll().Where(x => (x.Email == usuarioDto.Email || x.Telefone == usuarioDto.Telefone) && x.Senha == usuarioDto.Senha).FirstOrDefault();

      if (user == null)
      {
        return null;
      }

      var tokenHandler = new JwtSecurityTokenHandler();
      var key = Encoding.ASCII.GetBytes(Settings.Secret);
      var tokenDescriptor = new SecurityTokenDescriptor
      {
        Subject = new ClaimsIdentity(new Claim[]
          {
            new Claim(ClaimTypes.Email, user.Email),
            new Claim("Store", "user")
          }
        ),
        Expires = DateTime.UtcNow.AddDays(7),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      };

      var token = tokenHandler.CreateToken(tokenDescriptor);

      var userDto = mapperUsuario.MapperEntityToDto(user);

      userDto.Token = tokenHandler.WriteToken(token);

      return userDto;
    }


  }
}

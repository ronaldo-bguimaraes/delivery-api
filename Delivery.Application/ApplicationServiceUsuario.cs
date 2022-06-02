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

    public void Add(UsuarioDto UsuarioDto)
    {
      var Usuario = mapperUsuario.MapperDtoToEntity(UsuarioDto);
      serviceUsuario.Add(Usuario);
    }

    public IEnumerable<UsuarioDto> GetAll()
    {
      var Usuario = serviceUsuario.GetAll();
      return mapperUsuario.MapperEntitiesToDtos(Usuario);
    }

    public UsuarioDto GetById(int id)
    {
      var Usuario = serviceUsuario.GetById(id);
      return mapperUsuario.MapperEntityToDto(Usuario);
    }

    public void Remove(UsuarioDto UsuarioDto)
    {
      var Usuario = mapperUsuario.MapperDtoToEntity(UsuarioDto);
      serviceUsuario.Remove(Usuario);
    }

    public void Update(UsuarioDto UsuarioDto)
    {
      var cliente = mapperUsuario.MapperDtoToEntity(UsuarioDto);
      serviceUsuario.Update(cliente);
    }
        public string Authenticate(string email, string senha)
        {
            var user = serviceUsuario.GetAll().Where(x => x.Email == email && x.Senha == senha).FirstOrDefault();

            if (user == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Email),
                    new Claim("Store", "user")
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
               return tokenHandler.WriteToken(token);
        }


    }
}

using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using System.Collections.Generic;

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
  }
}

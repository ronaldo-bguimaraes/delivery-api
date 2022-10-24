using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Application.Dtos;
using System.Collections.Generic;
using Delivery.Application.Interfaces.Mappers;

namespace Delivery.Application
{
  public class ApplicationServiceEndereco : IApplicationServiceEndereco
  {
    private readonly IServiceEndereco serviceEndereco;
    private readonly IMapperEndereco mapperEndereco;

    public ApplicationServiceEndereco(IServiceEndereco _serviceEndereco, IMapperEndereco _mapperEndereco)
    {
      serviceEndereco = _serviceEndereco;
      mapperEndereco = _mapperEndereco;
    }

    public void Save(EnderecoDto enderecoDto)
    {
      var endereco = mapperEndereco.MapperDtoToEntity(enderecoDto);
      if (serviceEndereco.GetById(endereco.Id) == null)
      {
        serviceEndereco.Add(endereco);
      }
      else
      {
        serviceEndereco.Update(endereco);
      }
    }

    public ICollection<EnderecoDto> GetAll()
    {
      var enderecos = serviceEndereco.GetAll();
      return mapperEndereco.MapperEntitiesToDtos(enderecos);
    }

    public EnderecoDto GetById(int id)
    {
      var endereco = serviceEndereco.GetById(id);
      return mapperEndereco.MapperEntityToDto(endereco);
    }

    public ICollection<EnderecoDto> GetByUsuarioId(int usuarioId)
    {
      var enderecos = serviceEndereco.GetByUsuarioId(usuarioId);
      return mapperEndereco.MapperEntitiesToDtos(enderecos);
    }

    public void Remove(EnderecoDto enderecoDto)
    {
      var endereco = mapperEndereco.MapperDtoToEntity(enderecoDto);
      serviceEndereco.Remove(endereco);
    }
  }
}

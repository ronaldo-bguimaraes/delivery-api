using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using System.Collections.Generic;

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
      if (serviceEndereco.GetById(endereco.EnderecoId) == null)
      {
        serviceEndereco.Add(endereco);
      }
      else
      {
        serviceEndereco.Update(endereco);
      }
    }

    public IEnumerable<EnderecoDto> GetAll()
    {
      var enderecos = serviceEndereco.GetAll();
      return mapperEndereco.MapperEntitiesToDtos(enderecos);
    }

    public EnderecoDto GetById(int id)
    {
      var endereco = serviceEndereco.GetById(id);
      return mapperEndereco.MapperEntityToDto(endereco);
    }

    public IEnumerable<EnderecoDto> GetByUsuarioId(int id)
    {
      var enderecos = serviceEndereco.GetByUsuarioId(id);
      return mapperEndereco.MapperEntitiesToDtos(enderecos);
    }

    public void Remove(EnderecoDto enderecoDto)
    {
      var endereco = mapperEndereco.MapperDtoToEntity(enderecoDto);
      serviceEndereco.Remove(endereco);
    }
  }
}

using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Application.Dtos;
using System.Collections.Generic;
using Delivery.Application.Interfaces.Mappers;

namespace Delivery.Application
{
  public class ApplicationServiceCliente : IApplicationServiceCliente
  {
    private readonly IServiceCliente serviceCliente;
    private readonly IMapperCliente mapperCliente;

    public ApplicationServiceCliente(IServiceCliente _serviceCliente, IMapperCliente _mapperCliente)
    {
      serviceCliente = _serviceCliente;
      mapperCliente = _mapperCliente;
    }

    public void Save(ClienteDto clienteDto)
    {
      var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
      if (serviceCliente.GetById(cliente.Id) == null)
      {
        serviceCliente.Add(cliente);
      }
      else
      {
        serviceCliente.Update(cliente);
      }
    }

    public ICollection<ClienteDto> GetAll()
    {
      var clientes = serviceCliente.GetAll();
      return mapperCliente.MapperEntitiesToDtos(clientes);
    }

    public ClienteDto GetById(int id)
    {
      var cliente = serviceCliente.GetById(id);
      return mapperCliente.MapperEntityToDto(cliente);
    }

    public ClienteDto GetByUsuarioId(int id)
    {
      var cliente = serviceCliente.GetByUsuarioId(id);
      return mapperCliente.MapperEntityToDto(cliente);
    }

    public void Remove(ClienteDto clienteDto)
    {
      var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
      serviceCliente.Remove(cliente);
    }
  }
}

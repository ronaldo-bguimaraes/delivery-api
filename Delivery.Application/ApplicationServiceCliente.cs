using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using System.Collections.Generic;

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
    public void Add(ClienteDto clienteDto)
    {
      var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
      serviceCliente.Add(cliente);
    }

    public IEnumerable<ClienteDto> GetAll()
    {
      var clientes = serviceCliente.GetAll();
      return mapperCliente.MapperEntitiesToDtos(clientes);
    }

    public ClienteDto GetById(int id)
    {
      var cliente = serviceCliente.GetById(id);
      return mapperCliente.MapperEntityToDto(cliente);
    }

    public void Remove(ClienteDto clienteDto)
    {
      var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
      serviceCliente.Remove(cliente);
    }

    public void Update(ClienteDto clienteDto)
    {
      var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
      serviceCliente.Update(cliente);
    }
  }
}

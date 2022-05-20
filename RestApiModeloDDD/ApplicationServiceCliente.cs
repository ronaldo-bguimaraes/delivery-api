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

    public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente _mapperCliente)
    {
      this.serviceCliente = serviceCliente;
      this.mapperCliente = _mapperCliente;
    }
    public void Add(ClienteDto clienteDto)
    {
      var cliente = mapperCliente.MapperDtoToEntity(clienteDto);
      serviceCliente.Add(cliente);
    }

    public IEnumerable<ClienteDto> GetAll()
    {
      var clientes = serviceCliente.GetAll();
      return mapperCliente.MapperlistClientesDto(clientes);


    }

    public ClienteDto GetById(int id)
    {
      var cliente = serviceCliente.GetTById(id);
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

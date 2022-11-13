using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Application.Dtos;
using System.Collections.Generic;
using Delivery.Application.Interfaces.Mappers;

namespace Delivery.Application
{
  public class ApplicationServiceVenda : IApplicationServiceVenda
  {
    private readonly IServiceVenda serviceVenda;
    private readonly IMapperVenda mapperVenda;

    public ApplicationServiceVenda(IServiceVenda _serviceVenda, IMapperVenda _mapperVenda)
    {
      serviceVenda = _serviceVenda;
      mapperVenda = _mapperVenda;
    }

    public void Save(VendaDto vendaDto)
    {
      var venda = mapperVenda.MapperDtoToEntity(vendaDto);
      if (serviceVenda.GetById(venda.Id) == null)
      {
        serviceVenda.realizarVenda(venda);
      }
      else
      {
        serviceVenda.Update(venda);
      }
    }

    public ICollection<VendaDto> GetAll()
    {
      var vendas = serviceVenda.All();
      return mapperVenda.MapperEntitiesToDtos(vendas);
    }

    public VendaDto GetById(int id)
    {
      var venda = serviceVenda.GetById(id);
      return mapperVenda.MapperEntityToDto(venda);
    }

    public ICollection<VendaDto> GetByClienteId(int clienteId)
    {
      var vendas = serviceVenda.GetByClienteId(clienteId);
      return mapperVenda.MapperEntitiesToDtos(vendas);
    }

    public void Remove(VendaDto vendaDto)
    {
      var venda = mapperVenda.MapperDtoToEntity(vendaDto);
      serviceVenda.Remove(venda);
    }
  }
}

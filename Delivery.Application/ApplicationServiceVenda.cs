using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Application.Dtos;
using System.Collections.Generic;
using Delivery.Application.Interfaces.Mappers;

namespace Delivery.Application
{
  public class ApplicationServiceVenda : IApplicationServiceVenda
  {
    private readonly IServiceVenda ServiceVenda;
    private readonly IMapperVenda MapperVenda;

    public ApplicationServiceVenda(IServiceVenda serviceVenda, IMapperVenda mapperVenda)
    {
      ServiceVenda = serviceVenda;
      MapperVenda = mapperVenda;
    }

    public void Save(VendaDto vendaDto)
    {
      var venda = MapperVenda.MapperDtoToEntity(vendaDto);
      if (ServiceVenda.GetById(venda.Id) == null)
      {
        ServiceVenda.Solicitar(venda);
      }
      else
      {
        ServiceVenda.Update(venda);
      }
    }

    public ICollection<VendaDto> GetAll()
    {
      var vendas = ServiceVenda.All();
      return MapperVenda.MapperEntitiesToDtos(vendas);
    }

    public VendaDto GetById(int id)
    {
      var venda = ServiceVenda.GetById(id);
      return MapperVenda.MapperEntityToDto(venda);
    }

    public ICollection<VendaDto> GetByClienteId(int id)
    {
      var vendas = ServiceVenda.GetByClienteId(id);
      return MapperVenda.MapperEntitiesToDtos(vendas);
    }

    public void Remove(VendaDto vendaDto)
    {
      var venda = MapperVenda.MapperDtoToEntity(vendaDto);
      ServiceVenda.Remove(venda);
    }
  }
}

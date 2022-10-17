using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using System.Collections.Generic;

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

    public void Save(VendaDto produtoDto)
    {
      var produto = mapperVenda.MapperDtoToEntity(produtoDto);
      if (serviceVenda.GetById(produto.Id) == null)
      {
        serviceVenda.Add(produto);
      }
      else
      {
        serviceVenda.Update(produto);
      }
    }

    public IEnumerable<VendaDto> GetAll()
    {
      var enderecos = serviceVenda.GetAll();
      return mapperVenda.MapperEntitiesToDtos(enderecos);
    }

    public VendaDto GetById(int id)
    {
      var endereco = serviceVenda.GetById(id);
      return mapperVenda.MapperEntityToDto(endereco);
    }

    public void Remove(VendaDto enderecoDto)
    {
      var endereco = mapperVenda.MapperDtoToEntity(enderecoDto);
      serviceVenda.Remove(endereco);
    }
  }
}

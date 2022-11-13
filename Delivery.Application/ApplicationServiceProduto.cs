using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Application.Dtos;
using System.Collections.Generic;
using Delivery.Application.Interfaces.Mappers;

namespace Delivery.Application
{
  public class ApplicationServiceProduto : IApplicationServiceProduto
  {
    private readonly IServiceProduto serviceProduto;
    private readonly IMapperProduto mapperProduto;

    public ApplicationServiceProduto(IServiceProduto _serviceProduto, IMapperProduto _mapperProduto)
    {
      serviceProduto = _serviceProduto;
      mapperProduto = _mapperProduto;
    }

    public void Save(ProdutoDto produtoDto)
    {
      var produto = mapperProduto.MapperDtoToEntity(produtoDto);
      if (serviceProduto.GetById(produto.Id) == null)
      {
        serviceProduto.Add(produto);
      }
      else
      {
        serviceProduto.Update(produto);
      }
    }

    public ICollection<ProdutoDto> GetAll()
    {
      var enderecos = serviceProduto.All();
      return mapperProduto.MapperEntitiesToDtos(enderecos);
    }

    public ProdutoDto GetById(int id)
    {
      var endereco = serviceProduto.GetById(id);
      return mapperProduto.MapperEntityToDto(endereco);
    }

    public void Remove(ProdutoDto enderecoDto)
    {
      var endereco = mapperProduto.MapperDtoToEntity(enderecoDto);
      serviceProduto.Remove(endereco);
    }
  }
}

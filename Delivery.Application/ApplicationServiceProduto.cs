using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Application.Dtos;
using System.Collections.Generic;
using Delivery.Application.Interfaces.Mappers;

namespace Delivery.Application
{
  public class ApplicationServiceProduto : IApplicationServiceProduto
  {
    private readonly IServiceProduto ServiceProduto;
    private readonly IMapperProduto MapperProduto;

    public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto)
    {
      ServiceProduto = serviceProduto;
      MapperProduto = mapperProduto;
    }

    public void Save(ProdutoDto produtoDto)
    {
      var produto = MapperProduto.MapperDtoToEntity(produtoDto);
      if (ServiceProduto.GetById(produto.Id) == null)
      {
        ServiceProduto.Add(produto);
      }
      else
      {
        ServiceProduto.Update(produto);
      }
    }

    public ICollection<ProdutoDto> GetAll()
    {
      var enderecos = ServiceProduto.GetAll();
      return MapperProduto.MapperEntitiesToDtos(enderecos);
    }

    public ProdutoDto GetById(int id)
    {
      var endereco = ServiceProduto.GetById(id);
      return MapperProduto.MapperEntityToDto(endereco);
    }

    public ICollection<ProdutoDto> GetByFornecedorId(int id)
    {
      var vendas = ServiceProduto.GetByFornecedorId(id);
      return MapperProduto.MapperEntitiesToDtos(vendas);
    }

    public void Remove(ProdutoDto enderecoDto)
    {
      var endereco = MapperProduto.MapperDtoToEntity(enderecoDto);
      ServiceProduto.Remove(endereco);
    }
  }
}

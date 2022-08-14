using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using System.Collections.Generic;

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

    public void Add(ProdutoDto enderecoDto)
    {
      var endereco = mapperProduto.MapperDtoToEntity(enderecoDto);
      serviceProduto.Add(endereco);
    }

    public IEnumerable<ProdutoDto> GetAll()
    {
      var enderecos = serviceProduto.GetAll();
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

    public void Update(ProdutoDto enderecoDto)
    {
      var endereco = mapperProduto.MapperDtoToEntity(enderecoDto);
      serviceProduto.Update(endereco);
    }
  }
}

using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using System.Collections.Generic;

namespace Delivery.Application.Mappers
{
  public class ApplicationServiceProduto : IApplicationServiceProduto
  {

    private readonly IServiceProduto serviceProduto;
    private readonly IMapperUsuario mapperProduto;
    public ApplicationServiceProduto(IServiceProduto _serviceproduto, IMapperUsuario _mapperProduto)
    {
      serviceProduto = _serviceproduto;
      mapperProduto = _mapperProduto;
    }

    public void Add(UsuarioDto produtoDto)
    {
      var produto = mapperProduto.MapperDtoToEntity(produtoDto);
      serviceProduto.Add(produto);
    }

    public IEnumerable<UsuarioDto> GetAll()
    {
      var produto = serviceProduto.GetAll();
      return mapperProduto.MapperlistClientesDto(produto);
    }

    public UsuarioDto GetById(int id)
    {
      var produto = serviceProduto.GetTById(id);
      return mapperProduto.MapperEntityToDto(produto);
    }

    public void Remove(UsuarioDto produtoDto)
    {
      var produto = mapperProduto.MapperDtoToEntity(produtoDto);
      serviceProduto.Remove(produto);
    }

    public void Update(UsuarioDto produtoDto)
    {
      var cliente = mapperProduto.MapperDtoToEntity(produtoDto);
      serviceProduto.Update(cliente);
    }
  }
}

using Delivery.Domain.Entities;
using Delivery.Application.Dtos;
using System.Collections.Generic;
using System.Linq;
using Delivery.Application.Interfaces.Mappers;

namespace Delivery.Application.Mappers
{
  public class MapperItemProduto : IMapperItemProduto
  {

    public ItemProduto MapperDtoToEntity(ItemProdutoDto itemProdutoDto)
    {
      var itemProduto = new ItemProduto
      {
        Id = itemProdutoDto.Id,
        ProdutoId = itemProdutoDto.ProdutoId,
        VendaId = itemProdutoDto.VendaId,
        Valor = itemProdutoDto.Valor,
        Quantidade = itemProdutoDto.Quantidade,
      };
      return itemProduto;
    }

    public ItemProdutoDto MapperEntityToDto(ItemProduto itemProduto)
    {
      var itemProdutoDto = new ItemProdutoDto
      {
        Id = itemProduto.Id,
        ProdutoId = itemProduto.ProdutoId,
        VendaId = itemProduto.VendaId,
        Valor = itemProduto.Valor,
        Quantidade = itemProduto.Quantidade,
      };
      return itemProdutoDto;
    }

    public ICollection<ItemProdutoDto> MapperEntitiesToDtos(ICollection<ItemProduto> itemProdutos)
    {
      var itemProdutoDtos = itemProdutos.Select(itemProduto => new ItemProdutoDto
      {
        Id = itemProduto.Id,
        ProdutoId = itemProduto.ProdutoId,
        VendaId = itemProduto.VendaId,
        Valor = itemProduto.Valor,
        Quantidade = itemProduto.Quantidade,
      });
      return itemProdutoDtos.ToList();
    }

    public ICollection<ItemProduto> MapperDtosToEntities(ICollection<ItemProdutoDto> itemProdutoDtos)
    {
      var itemProduto = itemProdutoDtos.Select(itemProdutoDto => new ItemProduto
      {
        Id = itemProdutoDto.Id,
        ProdutoId = itemProdutoDto.ProdutoId,
        VendaId = itemProdutoDto.VendaId,
        Valor = itemProdutoDto.Valor,
        Quantidade = itemProdutoDto.Quantidade,
      });
      return itemProduto.ToList();
    }
  }
}




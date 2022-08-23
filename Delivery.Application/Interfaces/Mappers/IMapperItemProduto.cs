using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Infrastructure.CrossCutting.Interface
{
  public interface IMapperItemProduto //MapeamentoDTO para entidade
  {
    ItemProduto MapperDtoToEntity(ItemProdutoDto itemProdutoDto);
    IEnumerable<ItemProduto> MapperEntitiesToDtos(IEnumerable<ItemProduto> itensProduto);
    ItemProdutoDto MapperEntityToDto(ItemProduto itemProduto);
  }
}

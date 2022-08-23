using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Infrastructure.CrossCutting.Interface
{
  public interface IMapperItemProduto //MapeamentoDTO para entidade
  {
    ItemProduto MapperDtoToEntity(ItemProdutoDto clientedto);
    IEnumerable<ItemProduto> MapperEntitiesToDtos(IEnumerable<ItemProduto> itemProdutos);
    ItemProdutoDto MapperEntityToDto(ItemProduto itemProduto);
  }
}

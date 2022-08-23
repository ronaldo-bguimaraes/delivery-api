using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceItemProduto
  {
    void Save(ItemProdutoDto itemProdutoDto);

    void Remove(ItemProdutoDto itemProdutoDto);

    IEnumerable<ItemProdutoDto> GetAll();

    ItemProdutoDto GetById(int id);

    ItemProdutoDto GetByUsuarioId(int id);

  }
}

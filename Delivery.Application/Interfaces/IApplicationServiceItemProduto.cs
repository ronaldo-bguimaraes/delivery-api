using Delivery.Application.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceItemProduto
  {
    void Save(ItemProdutoDto itemProdutoDto);

    void Remove(ItemProdutoDto itemProdutoDto);

    ICollection<ItemProdutoDto> GetAll();

    ItemProdutoDto GetById(int id);

    ItemProdutoDto GetByUsuarioId(int id);

  }
}

using Delivery.Application.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceItemProduto
  {
    public void Save(ItemProdutoDto itemProdutoDto);

    public void Remove(ItemProdutoDto itemProdutoDto);

    public ICollection<ItemProdutoDto> GetAll();

    public ItemProdutoDto GetById(int id);

    public ItemProdutoDto GetByUsuarioId(int id);

  }
}

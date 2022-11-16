using Delivery.Application.Dtos;

namespace Delivery.Application
{
  public interface IApplicationServiceItemProduto : IApplicationServiceBase<ItemProdutoDto>
  {
    public ItemProdutoDto GetByUsuarioId(int id);
  }
}

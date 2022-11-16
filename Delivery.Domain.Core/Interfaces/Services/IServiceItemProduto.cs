using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Interfaces.Services
{
  public interface IServiceItemProduto : IServiceBase<ItemProduto>
  {
    public void Processar(ItemProduto itemProduto);
  }
}

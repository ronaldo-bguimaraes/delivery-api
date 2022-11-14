using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Services
{
  public class ServiceItemProduto : ServiceBase<ItemProduto>, IServiceItemProduto
  {
    private readonly IRepositoryItemProduto repositoryItemProduto;
    private readonly IServiceProduto serviceProduto;
    private readonly IServicePagamento servicePagamento;

    public ServiceItemProduto(IRepositoryItemProduto _repositoryItemProduto, IServiceProduto _serviceProduto, IServicePagamento _servicePagamento) : base(_repositoryItemProduto)
    {
      repositoryItemProduto = _repositoryItemProduto;
      serviceProduto = _serviceProduto;
      servicePagamento = _servicePagamento;
    }

    public override void Add(ItemProduto itemProduto)
    {
      itemProduto.Produto = serviceProduto.GetById(itemProduto.ProdutoId.GetValueOrDefault());
      itemProduto.Processar();
      base.Add(itemProduto);
    }
  }
}

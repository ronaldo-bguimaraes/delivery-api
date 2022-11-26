using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Services
{
  public class ServiceItemProduto : ServiceBase<ItemProduto>, IServiceItemProduto
  {
    private readonly IRepositoryItemProduto RepositoryItemProduto;
    private readonly IServiceProduto ServiceProduto;

    public ServiceItemProduto(IRepositoryItemProduto repositoryItemProduto, IServiceProduto serviceProduto) : base(repositoryItemProduto)
    {
      RepositoryItemProduto = repositoryItemProduto;
      ServiceProduto = serviceProduto;
    }

    public override void Add(ItemProduto itemProduto)
    {
      Processar(itemProduto);
      base.Add(itemProduto);
    }

    public void Processar(ItemProduto itemProduto)
    {
      itemProduto.Produto = ServiceProduto.GetById(itemProduto.ProdutoId.GetValueOrDefault());
      itemProduto.Processar();
    }
  }
}

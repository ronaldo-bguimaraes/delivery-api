using System;
using System.Linq;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Core.Services.Exceptions;
using Delivery.Domain.Entities;
using Delivery.Domain.Enums;

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
      itemProduto.processar();
      base.Add(itemProduto);
    }
  }
}

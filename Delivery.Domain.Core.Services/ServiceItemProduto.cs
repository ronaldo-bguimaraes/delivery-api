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
    private readonly IServicePagamento servicePagamento;

    public ServiceItemProduto(IRepositoryItemProduto _repositoryItemProduto, IServicePagamento _servicePagamento) : base(_repositoryItemProduto)
    {
      repositoryItemProduto = _repositoryItemProduto;
      servicePagamento = _servicePagamento;
    }

    public override void Add(ItemProduto itemProduto)
    {
      processarItemProduto(itemProduto);
      base.Add(itemProduto);
    }

    public void processarItemProduto(ItemProduto itemProduto)
    {
      itemProduto.Valor = itemProduto.Produto.Valor;
    }
  }
}

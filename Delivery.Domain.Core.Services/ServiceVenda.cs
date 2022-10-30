using System;
using System.Collections.Generic;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Core.Services.Exceptions;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Services
{
  public class ServiceVenda : ServiceBase<Venda>, IServiceVenda
  {
    private readonly IRepositoryVenda repositoryVenda;
    private readonly IServiceItemProduto serviceItemProduto;
    private readonly IServicePagamento servicePagamento;

    public ServiceVenda(IRepositoryVenda _repositoryVenda, IServiceItemProduto _serviceItemProduto, IServicePagamento _servicePagamento) : base(_repositoryVenda)
    {
      repositoryVenda = _repositoryVenda;
      serviceItemProduto = _serviceItemProduto;
      servicePagamento = _servicePagamento;
    }

    public ICollection<Venda> GetByClienteId(int clienteId)
    {
      return repositoryVenda.GetByClienteId(clienteId);
    }

    public void realizarVenda(Venda venda)
    {
      try
      {
        venda.setSolicitada();
        foreach (var itemProduto in venda.ItensProduto)
        {
          serviceItemProduto.Add(itemProduto);
        }
        venda.setDataVendaAtual();
        venda.processar();
        base.Add(venda);
      }
      catch (Exception)
      {
        throw;
      }
    }

    public void confirmarVenda(Venda venda)
    {
      venda.setConfirmada();
      base.Update(venda);
    }

    public void cancelarVenda(Venda venda)
    {
      venda.setCancelada();
      base.Update(venda);
    }

    public void validarVenda(Venda venda)
    {
      try {
        venda.validar();
      }
      catch {
        throw new PagamentoInsuficienteServiceException();
      }
    }
  }
}

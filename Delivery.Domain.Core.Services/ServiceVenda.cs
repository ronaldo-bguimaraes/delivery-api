using System;
using System.Linq;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Core.Services.Exceptions;
using Delivery.Domain.Entities;
using Delivery.Domain.Enums;

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

    public void realizarVenda(Venda venda)
    {
      try
      {
        venda.Condicao = CondicaoVenda.Solicitada;
        foreach (var itemProduto in venda.ItensProduto)
        {
          serviceItemProduto.Add(itemProduto);
        }
        venda.DataVenda = DateTime.Now.ToUniversalTime();
        processarVenda(venda);
        base.Add(venda);
      }
      catch (Exception)
      {
        throw;
      }
    }

    public void confirmarVenda(Venda venda)
    {
      try
      {
        servicePagamento.validarPagamento(venda.Pagamento);
        venda.Condicao = CondicaoVenda.Confirmada;
        base.Update(venda);
      }
      catch (Exception)
      {
        throw;
      }
    }

    public void cancelarVenda(Venda venda)
    {
      venda.Condicao = CondicaoVenda.Cancelada;
      base.Update(venda);
    }

    public void validarVenda(Venda venda)
    {
      if (venda.Pagamento.Valor < venda.Total)
      {
        throw new PagamentoInsuficienteServiceException();
      }
    }

    public void processarVenda(Venda venda)
    {
      venda.Subtotal = venda.ItensProduto.Sum(e => e.Valor * e.Quantidade);
      venda.Total = venda.Subtotal - venda.Desconto;
    }
  }
}

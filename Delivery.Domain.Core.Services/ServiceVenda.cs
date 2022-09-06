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
    private readonly IServicePagamento servicePagamento;

    public ServiceVenda(IRepositoryVenda _repositoryVenda, IServicePagamento _servicePagamento) : base(_repositoryVenda)
    {
      repositoryVenda = _repositoryVenda;
      servicePagamento = _servicePagamento;
    }

    public override void Add(Venda venda)
    {
      processarVenda(venda);
      venda.DataVenda = DateTime.Now;
      base.Add(venda);
    }

    public void realizarVenda(Venda venda)
    {
      try
      {
        processarVenda(venda);
        venda.Condicao = CondicaoVenda.Solicitada;
        validarVenda(venda);
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

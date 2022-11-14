using System;
using System.Collections.Generic;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;
using Delivery.Domain.Validators;
using FluentValidation;

namespace Delivery.Domain.Core.Services
{
  public class ServiceVenda : ServiceBase<Venda>, IServiceVenda
  {
    private readonly IRepositoryVenda repositoryVenda;
    private readonly IServiceItemProduto serviceItemProduto;
    private readonly IServicePagamento servicePagamento;

    private readonly VendaValidator validator;

    public ServiceVenda(IRepositoryVenda _repositoryVenda, IServiceItemProduto _serviceItemProduto, IServicePagamento _servicePagamento, VendaValidator _validator) : base(_repositoryVenda)
    {
      repositoryVenda = _repositoryVenda;
      serviceItemProduto = _serviceItemProduto;
      servicePagamento = _servicePagamento;
      validator = _validator;
    }

    public ICollection<Venda> GetByClienteId(int clienteId)
    {
      return repositoryVenda.GetByClienteId(clienteId);
    }

    public void realizarVenda(Venda venda)
    {
      try
      {
        venda.SetSolicitada();
        foreach (var itemProduto in venda.ItensProduto)
        {
          serviceItemProduto.Add(itemProduto);
        }
        venda.SetDataVendaAtual();
        venda.Processar();
        base.Add(venda);
      }
      catch (Exception)
      {
        throw;
      }
    }

    public void confirmarVenda(Venda venda)
    {
      venda.SetConfirmada();
      base.Update(venda);
    }

    public void cancelarVenda(Venda venda)
    {
      venda.SetCancelada();
      base.Update(venda);
    }

    public void validarVenda(Venda venda)
    {
      var validator = new VendaValidator();
      validator.ValidateAndThrow(venda);
    }
  }
}

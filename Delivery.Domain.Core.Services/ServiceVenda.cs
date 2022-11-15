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
    private readonly IRepositoryVenda RepositoryVenda;
    private readonly IServiceItemProduto ServiceItemProduto;
    private readonly IServicePagamento ServicePagamento;

    private readonly VendaValidator Validator;

    public ServiceVenda(IRepositoryVenda repositoryVenda, IServiceItemProduto serviceItemProduto, IServicePagamento servicePagamento, VendaValidator validator) : base(repositoryVenda)
    {
      RepositoryVenda = repositoryVenda;
      ServiceItemProduto = serviceItemProduto;
      ServicePagamento = servicePagamento;
      Validator = validator;
    }

    public ICollection<Venda> GetByClienteId(int clienteId)
    {
      return RepositoryVenda.GetByClienteId(clienteId);
    }

    public void Solicitar(Venda venda)
    {
      venda.SetSolicitada();
      venda.SetDataVendaAtual();
      Processar(venda);
      Validator.ValidateAndThrow(venda);
      base.Add(venda);
    }

    public void Confirmar(Venda venda)
    {
      venda.SetConfirmada();
      Validator.ValidateAndThrow(venda);
      base.Update(venda);
    }

    public void Cancelar(Venda venda)
    {
      venda.SetCancelada();
      Validator.ValidateAndThrow(venda);
      base.Update(venda);
    }

    public void Processar(Venda venda)
    {
      foreach (var itemProduto in venda.ItensProduto)
      {
        ServiceItemProduto.Processar(itemProduto);
      }
      venda.Processar();
    }
  }
}

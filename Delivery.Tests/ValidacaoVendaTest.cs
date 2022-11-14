using System;
using System.Collections.Generic;
using Delivery.Application;
using Delivery.Application.Dtos;
using Delivery.Application.Interfaces.Mappers;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;
using Delivery.Domain.Enums;
using Delivery.Domain.Validators;
using Moq;
using Xunit;

namespace Delivery.Tests
{
  public class ValidacaoVendaTest
  {
    [Fact]
    public void DadosCorretosTest()
    {
      var itemProduto1 = new ItemProduto
      {
        Produto = new Produto { FornecedorId = 1 }
      };
      var itemProduto2 = new ItemProduto
      {
        Produto = new Produto { FornecedorId = 1 }
      };

      var venda = new Venda()
      {
        ClienteId = 1,
        Condicao = CondicaoVenda.Solicitada,
        DataVenda = DateTime.UtcNow,
        Desconto = 10,
        Subtotal = 200,
        Frete = 10,
        ItensProduto = new List<ItemProduto> { itemProduto1, itemProduto2 },
      };

      var vendaValidator = new VendaValidator();
      var result = vendaValidator.Validate(venda);

      Assert.True(result.IsValid);
    }

    [Fact]
    public void DadosIncorretosTest()
    {
      var venda = new Venda()
      {
        DataVenda = new DateTime(2024, 12, 22),
        Desconto = -10,
        Subtotal = 100,
        Frete = -10,
      };

      var vendaValidator = new VendaValidator();
      var result = vendaValidator.Validate(venda);

      Assert.False(result.IsValid);
    }

    [Fact]
    public void VariosFornecedoresTest()
    {
      var itemProduto1 = new ItemProduto
      {
        Produto = new Produto { FornecedorId = 1 }
      };
      var itemProduto2 = new ItemProduto
      {
        Produto = new Produto { FornecedorId = 2 }
      };

      var venda = new Venda()
      {
        ClienteId = 1,
        Condicao = CondicaoVenda.Solicitada,
        DataVenda = DateTime.UtcNow,
        Desconto = 10,
        Subtotal = 200,
        Frete = 10,
        ItensProduto = new List<ItemProduto> { itemProduto1, itemProduto2 },
      };

      var vendaValidator = new VendaValidator();
      var result = vendaValidator.Validate(venda);

      Assert.False(result.IsValid);
    }
     
    [Fact]
    public void ProcessarVenda()
    {
      var ItemProduto = new ItemProduto
      {
        Valor = 10, 
        Quantidade = 3 
      };
      var Venda = new Venda()
      {
       Desconto = 10,
       Frete = 7,
       ItensProduto = new List<ItemProduto> {ItemProduto},
     };
       var Subtotal = 30;
       var ValoCorreto = 27;
         Venda.processar();
          Assert.True(Venda.Total == ValoCorreto);
          Assert.True(Venda.Subtotal == Subtotal);
    } 
  }
}
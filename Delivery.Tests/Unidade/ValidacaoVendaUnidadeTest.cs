using System;
using System.Collections.Generic;
using Delivery.Domain.Entities;
using Delivery.Domain.Enums;
using Delivery.Domain.Validators;
using Xunit;

namespace Delivery.Tests
{
  public class ValidacaoVendaUnidadeTest
  {
    [Fact]
    public void DadosCorretosTest()
    {
      var itemProduto1 = new ItemProduto
      {
        FornecedorId = 1
      };
      var itemProduto2 = new ItemProduto
      {
        FornecedorId = 1
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

      var validator = new VendaValidator();
      var result = validator.Validate(venda);

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

      var validator = new VendaValidator();
      var result = validator.Validate(venda);

      Assert.False(result.IsValid);
    }

    [Fact]
    public void VariosFornecedoresTest()
    {
      var itemProduto1 = new ItemProduto
      {
        FornecedorId = 1
      };
      var itemProduto2 = new ItemProduto
      {
        FornecedorId = 2
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

      var validator = new VendaValidator();
      var result = validator.Validate(venda);

      Assert.False(result.IsValid);
    }
  }
}

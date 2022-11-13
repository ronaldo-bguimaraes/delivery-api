using System;
using System.Collections.Generic;
using Delivery.Domain.Entities;
using Xunit;

namespace Delivery.Tests
{
  public class ProcessarVendaTest
  {
    [Fact]
    public void ProcessarVenda()
    {
      var itemProduto = new ItemProduto
      {
        Valor = 10,
        Quantidade = 3
      };
      var venda = new Venda
      {
        Desconto = 10,
        Frete = 7,
        ItensProduto = new List<ItemProduto> { itemProduto },
      };
      var Total = 27;
      var Subtotal = 30;

      venda.Processar();

      Assert.True(Math.Abs(venda.Total - Total) < 0.001);
      Assert.True(Math.Abs(venda.Subtotal - Subtotal) < 0.001);
    }
  }
}
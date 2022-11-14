using System;
using System.Collections.Generic;
using Delivery.Domain.Entities;
using Xunit;

namespace Delivery.Tests
{
  public class ProcessarVendaUnidadeTest
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

      var total = 27;
      var subtotal = 30;

      venda.Processar();

      Assert.True(Math.Abs(venda.Total - total) < 0.001);
      Assert.True(Math.Abs(venda.Subtotal - subtotal) < 0.001);
    }
  }
}

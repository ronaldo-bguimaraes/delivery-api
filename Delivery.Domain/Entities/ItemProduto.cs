using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Domain.Entities
{
  public class ItemProduto
  {
    public int itemProduto_id { get; set; }
    public double valor { get; set; }
    public int quantidade { get; set; }
    public Produto produto_id { get; set; }
    public Venda venda { get; set; }
    public int venda_id { get; set; }
  }
}

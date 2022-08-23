using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Domain.Entities
{
  public class Venda
  {
    public Cliente cliente_id { get; set; }
    public double subtotal { get; set; }
    public double frete { get; set; }
    public double total { get; set; }
    public String data_venda { get; set; }
    public double desconto { get; set; }
    public bool condicao { get; set; }
    public Entregador entregador { get; set; }
    public int entregador_id { get; set; }
    public Pagamento pagamento { get; set; }
    public int pagamento_id { get; set; }
  }
}

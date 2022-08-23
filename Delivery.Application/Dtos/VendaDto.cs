using System;

namespace Delivery.Dtos
{
  public class VendaDto
  {
    public int cliente_id { get; set; }
    public double subtotal { get; set; }
    public double frete { get; set; }
    public double total { get; set; }
    public String data_venda { get; set; }
    public double desconto { get; set; }
    public bool condicao { get; set; }
    public int entregador_id { get; set; }
    public int pagamento_id { get; set; }
  }
}

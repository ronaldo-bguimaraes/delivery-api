namespace Delivery.Dtos
{
  public class PagamentoDto
  {
    public int pagamento_id { get; set; }
    public double valor { get; set; }
    public string dt_pagamento { get; set; }
    public int formaPagamento_id { get; set; }
  }
}

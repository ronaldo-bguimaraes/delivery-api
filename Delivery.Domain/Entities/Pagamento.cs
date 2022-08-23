using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Domain.Entities
{
  public class Pagamento
  {
    public int pagamento_id { get; set; }
    public double valor { get; set; }
    public string dt_pagamento { get; set; }
    public FormaPagamento formaPagamento { get; set; }
    public int formaPagamento_id { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Delivery.Domain.Entities
{
    public class PagamentoDto{
        public int pagamento_id { get; set; } 
        public double valor { get; set; }
        public string dt_pagamento { get; set; }
        public FormaPagamentoDto formaPagamento { get; set; }
        public int formaPagamento_id { get; set; }
    }
}

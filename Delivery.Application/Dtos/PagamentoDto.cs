using System;
using Delivery.Domain.Entities;

namespace Delivery.Application.Dtos
{
  public class PagamentoDto : EntityDto
  {
    public double Valor { get; set; }

    public DateTime DataPagamento { get; set; }
    
    public FormaPagamento FormaPagamento { get; set; }
  }
}

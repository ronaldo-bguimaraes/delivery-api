using System;
using Delivery.Domain.Entities;

namespace Delivery.Dtos
{
  public class PagamentoDto
  {
    public int Id { get; set; }
    public double Valor { get; set; }
    public DateTime DataPagamento { get; set; }
    public FormaPagamento FormaPagamento { get; set; }
  }
}

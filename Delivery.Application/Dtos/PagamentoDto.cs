using System;

namespace Delivery.Dtos
{
  public class PagamentoDto
  {
    public int Id { get; set; }
    public double Valor { get; set; }
    public DateTime DataPagamento { get; set; }
    public int FormaPagamento { get; set; }
  }
}

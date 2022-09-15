using Delivery.Domain.Enums;
using System;

namespace Delivery.Dtos
{
  public class VendaDto
  {
    public int Id { get; set; }

    public double Subtotal { get; set; }

    public double Frete { get; set; }

    public double Total { get; set; }

    public DateTime DataVenda { get; set; }

    public double Desconto { get; set; }

    public CondicaoVenda Condicao { get; set; }

    public int ClienteId { get; set; }

    public int EntregadorId { get; set; }
    
    public int PagamentoId { get; set; }
  }
}

using Delivery.Domain.Enums;
using System;
using System.Collections.Generic;

namespace Delivery.Application.Dtos
{
  public class VendaDto : EntityDto
  {
    public double Subtotal { get; set; }

    public double Frete { get; set; }

    public double Total { get; set; }

    public DateTime DataVenda { get; set; }

    public double Desconto { get; set; }

    public CondicaoVenda Condicao { get; set; }

    public ICollection<ItemProdutoDto> ItensProduto { get; set; }

    public int? ClienteId { get; set; }

    public int? EntregadorId { get; set; }

    public ICollection<PagamentoDto> Pagamentos { get; set; }
  }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Delivery.Domain.Enums;

namespace Delivery.Domain.Entities
{
  public class Venda : EntityBase
  {
    [Key]
    [Column("VendaId")]
    public override int Id { get; set; }

    public double Subtotal { get; set; }

    public double Frete { get; set; }

    public double Total { get; set; }

    public DateTime DataVenda { get; set; }

    public double Desconto { get; set; }

    [Column(TypeName = "int")]
    public Condicao Condicao { get; set; }

    public ICollection<ItemProduto> ItensProduto { get; set; }

    [ForeignKey("ClienteId")]
    public int ClienteId { get; set; }

    public virtual Cliente Cliente { get; set; }

    [ForeignKey("EntregadorId")]
    public int EntregadorId { get; set; }

    public virtual Entregador Entregador { get; set; }

    [ForeignKey("PagamentoId")]
    public int PagamentoId { get; set; }

    public virtual Pagamento Pagamento { get; set; }
  }
}

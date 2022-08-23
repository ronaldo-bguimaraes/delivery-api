using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  public class Pagamento : EntityBase
  {
    [Key]
    [Column("PagamentoId")]
    public override int Id { get; set; }
    public double valor { get; set; }
    public string dt_pagamento { get; set; }
    public int formaPagamento_id { get; set; }
    public FormaPagamento formaPagamento { get; set; }
  }
}

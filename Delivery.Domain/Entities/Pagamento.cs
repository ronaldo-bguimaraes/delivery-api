using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  public class Pagamento : EntityBase
  {
    [Key]
    [Column("PagamentoId")]
    public override int Id { get; set; }

    public double Valor { get; set; }

    public DateTime DataPagamento { get; set; }

    [Column(TypeName = "int")]
    public FormaPagamento FormaPagamento { get; set; }
  }
}

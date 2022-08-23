using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  public class FormaPagamento : EntityBase
  {
    [Key]
    [Column("FormaPagamentoId")]
    public override int Id { get; set; }
    public string descricao { get; set; }
  }
}

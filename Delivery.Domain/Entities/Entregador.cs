using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  public class Entregador : EntityBase
  {
    [Key]
    [Column("EntregadorId")]
    public override int Id { get; set; }
    public int cpf { get; set; }
    public string sexo { get; set; }
    public bool verificado { get; set; }
    public Usuario usuario { get; set; }
    public int usuario_id { get; set; }
  }
}

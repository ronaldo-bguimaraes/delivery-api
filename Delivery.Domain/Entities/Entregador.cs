using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Delivery.Domain.Enums;

namespace Delivery.Domain.Entities
{
  public class Entregador : EntityBase
  {
    [Key]
    [Column("EntregadorId")]
    public override int Id { get; set; }

    [Column(TypeName = "char(11)")]
    public string Cpf { get; set; }

    [Column(TypeName = "int")]
    public Sexo Sexo { get; set; }

    public bool Verificado { get; set; }

    [ForeignKey("UsuarioId")]
    public int UsuarioId { get; set; }

    public virtual Usuario Usuario { get; set; }
  }
}

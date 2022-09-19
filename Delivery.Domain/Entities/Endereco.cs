using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  public class Endereco : EntityBase
  {
    [Key]
    [Column("EnderecoId")]
    public override int Id { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string Nome { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string Apelido { get; set; }

    [Column(TypeName = "varchar(200)")]
    public string Descricao { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string Complemento { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    [ForeignKey("UsuarioId")]
    public int? UsuarioId { get; set; }

    public virtual Usuario Usuario { get; set; }
  }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  public class Produto : EntityBase
  {
<<<<<<< Updated upstream
    [Key()]
    public int ProdutoId { get; set; }
=======
    [Key]
    [Column("ProdutoId")]
    public override int Id { get; set; }
>>>>>>> Stashed changes

    [Column(TypeName = "varchar(100)")]
    public string Descricao { get; set; }

    public double Valor { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string Ingredientes { get; set; }

    public bool Disponivel { get; set; }
  }
}

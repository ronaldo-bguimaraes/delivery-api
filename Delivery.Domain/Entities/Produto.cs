using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  public class Produto
  {
    [Key()]
    public int ProdutoId { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string Descricao { get; set; }

    public double Valor { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string Ingredientes { get; set; }

    public bool Disponivel { get; set; }
  }
}

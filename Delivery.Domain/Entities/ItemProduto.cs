using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  public class ItemProduto : EntityBase
  {
    [Key]
    [Column("ItemProdutoId")]
    public override int Id { get; set; }
    public double valor { get; set; }
    public int quantidade { get; set; }
    public Produto produto_id { get; set; }
    public Venda venda { get; set; }
    public int venda_id { get; set; }
  }
}

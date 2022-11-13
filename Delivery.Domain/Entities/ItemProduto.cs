using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  public class ItemProduto : EntityBase
  {
    [Key]
    [Column("ItemProdutoId")]
    public override int Id { get; set; }

    public double Valor { get; set; }

    public int Quantidade { get; set; }

    [ForeignKey("ProdutoId")]
    public int? ProdutoId { get; set; }

    public virtual Produto Produto { get; set; }

    [ForeignKey("VendaId")]
    public int? VendaId { get; set; }

    public virtual Venda Venda { get; set; }

    public void Processar()
    {
      Valor = Produto.Valor;
    }
  }
}

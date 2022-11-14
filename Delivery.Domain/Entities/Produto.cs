using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  public class Produto : EntityBase
  {
    [Key]
    [Column("ProdutoId")]
    public override int Id { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string Descricao { get; set; }

    public double Valor { get; set; }

    [Column(TypeName = "varchar(200)")]
    public string Ingredientes { get; set; }

    public bool Disponivel { get; set; }

    [ForeignKey("FornecedorId")]
    public int? FornecedorId { get; set; }

    public virtual Fornecedor Fornecedor { get; set; }
  }
}

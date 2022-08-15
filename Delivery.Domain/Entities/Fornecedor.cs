using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  public class Fornecedor
  {
    [Key]
    public int FornecedorId { get; set; }

    [Column(TypeName = "char(14)")]
    public string Cnpj { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string RazaoSocial { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string Email { get; set; }

    [ForeignKey("UsuarioId")]
    public int UsuarioId { get; set; }

    public virtual Usuario Usuario { get; set; }
  }
}

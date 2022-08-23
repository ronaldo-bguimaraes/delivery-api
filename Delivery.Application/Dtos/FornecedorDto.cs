using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  public class FornecedorDto
  {
    public int FornecedorId { get; set; }
    public string Cnpj { get; set; }
    public string RazaoSocial { get; set; }
    public string Email { get; set; }
    public int UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }
  }
}

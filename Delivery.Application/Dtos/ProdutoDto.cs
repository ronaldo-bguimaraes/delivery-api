using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  public class ProdutoDto
  {
    public int ProdutoId { get; set; }

    public string Descricao { get; set; }
    public double Valor { get; set; }
    public string Ingredientes { get; set; }
    
    public bool Disponivel { get; set; }
  }
}

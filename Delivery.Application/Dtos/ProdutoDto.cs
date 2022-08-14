using System;

namespace Delivery.Dtos
{
  public class ProdutoDto
  {
    public int Id { get; set; }

    public string Descricao { get; set; }

    public double Valor { get; set; }

    public string Ingredientes { get; set; }
    
    public bool Disponivel { get; set; }
  }
}
namespace Delivery.Application.Dtos
{
  public class ProdutoDto : EntityDto
  {
    public string Descricao { get; set; }

    public double Valor { get; set; }

    public string Ingredientes { get; set; }

    public bool Disponivel { get; set; }

    public int? FornecedorId { get; set; }
  }
}
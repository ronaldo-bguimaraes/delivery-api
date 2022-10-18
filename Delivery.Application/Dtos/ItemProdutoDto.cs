namespace Delivery.Application.Dtos
{
  public class ItemProdutoDto : EntityDto
  {
    public double Valor { get; set; }

    public int Quantidade { get; set; }

    public int? ProdutoId { get; set; }
    
    public int? VendaId { get; set; }
  }
}

namespace Delivery.Dtos
{
  public class ItemProdutoDto
  {
    public int Id { get; set; }
    public double Valor { get; set; }
    public int Quantidade { get; set; }
    public int ProdutoId { get; set; }
    public int VendaId { get; set; }
  }
}

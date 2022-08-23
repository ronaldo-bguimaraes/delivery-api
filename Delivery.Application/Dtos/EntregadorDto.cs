namespace Delivery.Dtos
{
  public class EntregadorDto
  {
    public int entregador_id { get; set; }
    public int cpf { get; set; }
    public string sexo { get; set; }
    public bool verificado { get; set; }
    public int usuario_id { get; set; }
  }
}

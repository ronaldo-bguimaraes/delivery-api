namespace Delivery.Dtos
{

  public class EnderecoDto
  {
    public int Id { get; set; }
    public string Apelido { get; set; }
    public int UsuarioId { get; set; }
    public string Complemento { get; set; }
    public string Descricao { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
  }
}

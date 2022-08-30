namespace Delivery.Dtos
{
  public class EntregadorDto
  {
    public int Id { get; set; }

    public int Cpf { get; set; }

    public string Sexo { get; set; }

    public bool Verificado { get; set; }
    
    public int UsuarioId { get; set; }
  }
}

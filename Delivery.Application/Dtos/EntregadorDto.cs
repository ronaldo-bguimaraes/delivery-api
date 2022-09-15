using Delivery.Domain.Enums;

namespace Delivery.Dtos
{
  public class EntregadorDto
  {
    public int Id { get; set; }

    public string Cpf { get; set; }

    public Sexo Sexo { get; set; }

    public bool Verificado { get; set; }
    
    public int UsuarioId { get; set; }
  }
}

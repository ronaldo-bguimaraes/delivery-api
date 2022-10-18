using Delivery.Domain.Enums;

namespace Delivery.Application.Dtos
{
  public class EntregadorDto : EntityDto
  {
    public string Cpf { get; set; }

    public Sexo Sexo { get; set; }

    public bool Verificado { get; set; }

    public int? UsuarioId { get; set; }
  }
}

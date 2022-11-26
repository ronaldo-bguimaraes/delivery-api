using System;

namespace Delivery.Application.Dtos
{
  public class ClienteDto : EntityDto
  {
    public string Cpf { get; set; }

    public DateTime DataNascimento { get; set; }

    public int UsuarioId { get; set; }
  }
}

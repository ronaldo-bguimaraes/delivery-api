using System;

namespace Delivery.Dtos
{
  public class ClienteDto
  {
    public int Id { get; set; }

    public string Cpf { get; set; }

    public DateTime DataNascimento { get; set; }

    public int UsuarioId { get; set; }
  }
}

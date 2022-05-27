using System;

namespace Delivery.Dtos
{
  public class ClienteDto
  {
    public int Id { get; set; }
    public int Cpf { get; set; }
    public DateTime DataNascimento { get; set; }
    public UsuarioDto Usuario { get; set; }
  }
}

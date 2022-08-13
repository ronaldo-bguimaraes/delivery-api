using System;
using System.Collections.Generic;

namespace Delivery.Domain.Entities
{
  public class Usuario
  {
    public int UsuarioId { get; set; }
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public DateTime DataCadastro { get; set; }
    public ICollection<Endereco> Enderecos { get; set; }
  }
}

using System;


namespace Delivery.Domain.Entities
{
  public class Cliente : Base
  {
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public DateTime DataCadastro { get; set; }
    public bool IsAtivo { get; set; }
    public string Email { get; set; }
  }
}

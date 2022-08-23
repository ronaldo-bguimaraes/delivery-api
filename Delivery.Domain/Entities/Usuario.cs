using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  public class Usuario
  {
    public int UsuarioId { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string Nome { get; set; }

    [Column(TypeName = "varchar(11)")]
    public string Telefone { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string Email { get; set; }

    [Column(TypeName = "varchar(25)")]
    public string Senha { get; set; }

    public DateTime DataCadastro { get; set; }
    
    public ICollection<Endereco> Enderecos { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;

namespace Delivery.Domain.Entities
{
  public class Usuario : EntityBase
  {
    [Key]
    [Column("UsuarioId")]
    public override int Id { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string Nome { get; set; }

    [Column(TypeName = "varchar(11)")]
    public string Telefone { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string Email { get; set; }

    [Column(TypeName = "char(32)")]
    public string Senha { get; set; }

    [NotMapped]
    public Claim Claim { get; set; }

    public DateTime DataCadastro { get; set; }

    public ICollection<Endereco> Enderecos { get; set; }

    public void SetDataCadastroAtual()
    {
      DataCadastro = DateTime.UtcNow;
    }
  }
}

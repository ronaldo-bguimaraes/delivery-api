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

    public virtual ICollection<Endereco> Enderecos { get; set; }

    public Usuario() {
      Enderecos = new List<Endereco>();
    }

    public void SetDataCadastroAtual()
    {
      DataCadastro = DateTime.UtcNow;
    }

    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }
      Usuario usuario = (Usuario)obj;
      if (usuario.Nome != Nome)
      {
        return false;
      }
      if (usuario.Email != Email)
      {
        return false;
      }
      if (usuario.Telefone != Telefone)
      {
        return false;
      }
      if (usuario.DataCadastro != DataCadastro)
      {
        return false;
      }
      return true;
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }
  }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  public class Cliente
  {
    [Key]
    public int ClienteId { get; set; }

    [Column(TypeName = "char(11)")]
    public string Cpf { get; set; }

    public DateTime DataNascimento { get; set; }

    public int UsuarioId { get; set; }

    public virtual Usuario Usuario { get; set; }
  }
}
using Delivery.Domain.Interfaces.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  [Table("Cliente")]
  public class Cliente : IBase
  {
    [Key, Column("cliente_id")]
    public int Id { get; set; }

    [Column("cpf")]
    public string Cpf { get; set; }

    [Column("dt_nascimento")]
    public DateTime DataNascimento { get; set; }

    [ForeignKey("usuario_id"), Column("usuario_id")]
    public int UsuarioId { get; set; }

    // public virtual Usuario Usuario { get; set; }
  }
}

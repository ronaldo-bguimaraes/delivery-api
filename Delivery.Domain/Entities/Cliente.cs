using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
  public class Cliente : EntityBase
  {
    [Key]
    [Column("ClienteId")]
    public override int Id { get; set; }

    [Column(TypeName = "char(11)")]
    public string Cpf { get; set; }

    public DateTime DataNascimento { get; set; }

    [ForeignKey("UsuarioId")]
    public int? UsuarioId { get; set; }

    public virtual Usuario Usuario { get; set; }

    public virtual IEnumerable<Venda> Vendas { get; set; }
  }
}
using Delivery.Domain.Interfaces.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
    [Table("Endereco")]
    public class Endereco : IBase
    {
        [Key, Column("endereco_id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("apelido")]
        public string Apelido { get; set; }

        [ForeignKey("usuario_id"), Column("usuario_id")]
        public int UsuarioId { get; set; }
        [Column("complemento")]
        public string Complemento { get; set; }
        [Column("descricao")]
        public string Descricao { get; set; }
        [Column("latitude")]
        public double Latidude { get; set; }
        [Column("longitude")]
        public double Longitude { get; set; }


        // public virtual Usuario Usuario { get; set; }
    }
}

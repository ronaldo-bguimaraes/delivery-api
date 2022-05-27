using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Domain.Entities
{
    [Table("Usuario")]
    public class Usuario : Base
    {
        [Key]
        [Column("usuario_id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("telefone")]
        public string Telefone { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("senha")]
        public string Senha { get; set; }
        [Column("dt_cadastro")]
        public DateTime DataCadastro { get; set; }
     
    }
}

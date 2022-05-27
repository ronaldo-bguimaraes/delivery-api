using System;

namespace Delivery.Dtos
{
  public class UsuarioDto
  {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public UsuarioDto(int id, string nome, string telefone, string email, string senha, DateTime dataCadastro)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Senha = senha;
            DataCadastro = dataCadastro;
        }

        public UsuarioDto()
        {
        }
    }
}

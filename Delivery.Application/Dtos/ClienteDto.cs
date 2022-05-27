using System;

namespace Delivery.Dtos
{
  public class ClienteDto
  {
        public int Id { get; set; }
        public int Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public UsuarioDto Usuario { get; set; }

        public ClienteDto(int id, int cpf, DateTime dataNascimento, UsuarioDto usuario)
        {
            Id = id;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Usuario = usuario;
        }

        public ClienteDto()
        {
        }
    }
}

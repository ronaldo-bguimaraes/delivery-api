using System;


namespace RestApiModeloDDD.Domain.Entities
{
    public class Cliente: Base{
        public String Nome { get; set; }
        public String Sobrenome { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IsAtivo { get; set; }
        public string Email { get; set; }

    }
}

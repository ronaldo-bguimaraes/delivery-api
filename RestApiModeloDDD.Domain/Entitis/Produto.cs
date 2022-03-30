using System;

namespace RestApiModeloDDD.Domain.Entities
{
    public class Produto: Base{
        public String  Nome { get; set; }
        public decimal Valor { get; set; }
        public bool IsDisponivel { get; set; }
    }
}

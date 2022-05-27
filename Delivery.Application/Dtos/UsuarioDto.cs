﻿using System;

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
  }
}
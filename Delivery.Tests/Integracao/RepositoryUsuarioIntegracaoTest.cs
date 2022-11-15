using System;
using System.Collections.Generic;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;
using Delivery.Infrastructure.Data.Repositories;
using Xunit;

namespace Delivery.Tests
{
  public class RepositoryUsuarioIntegracaoTest
  {
    private readonly SqlContextTest SqlContextTest;
    private readonly IRepositoryUsuario RepositoryUsuario;

    public RepositoryUsuarioIntegracaoTest()
    {
      SqlContextTest = new SqlContextTest();
      RepositoryUsuario = new RepositoryUsuario(SqlContextTest.SqlContext);
    }

    [Fact]
    public void AddUsuario()
    {
      var usuario = new Usuario
      {
        Nome = "Teste Add",
        Email = "teste.add@outlook.com",
        Telefone = "66998765432",
        DataCadastro = DateTime.UtcNow,
        Enderecos = new List<Endereco>(),
        Senha = "12345678",
      };
      try
      {
        RepositoryUsuario.Add(usuario);
      }
      catch
      {
        throw new Exception("Erro ao adicionar usuario no banco");
      }
      try
      {
        Usuario usuarioAdicionado = RepositoryUsuario.GetById(usuario.Id);
        Assert.True(usuario.Equals(usuarioAdicionado));
      }
      catch
      {
        throw new Exception("Erro ao recuperar usuario do banco");
      }
    }

    [Fact]
    public void UpdateUsuario()
    {
      var usuario = new Usuario
      {
        Nome = "Teste Update",
        Email = "teste.update@outlook.com",
        Telefone = "66998765432",
        DataCadastro = DateTime.UtcNow,
        Enderecos = new List<Endereco>(),
        Senha = "12345678",
      };
      try
      {
        RepositoryUsuario.Add(usuario);
        usuario.Senha = "87654321";
        RepositoryUsuario.Update(usuario);
        var usuarioAtualizado = RepositoryUsuario.GetById(usuario.Id);
        Assert.True(usuario.Equals(usuarioAtualizado));
      }
      catch
      {
        throw new Exception("Erro ao atualizar usuario");
      }
    }

    [Fact]
    public void RemoveUsuario()
    {
      var usuario = new Usuario
      {
        Nome = "Teste Remove",
        Email = "teste.remove@outlook.com",
        Telefone = "66998765432",
        DataCadastro = DateTime.UtcNow,
        Enderecos = new List<Endereco>(),
        Senha = "12345678",
      };
      try
      {
        RepositoryUsuario.Add(usuario);
        RepositoryUsuario.Remove(usuario);
        var usuarioRemovido = RepositoryUsuario.GetById(usuario.Id);
        Assert.Null(usuarioRemovido);
      }
      catch
      {
        throw new Exception("Erro ao remover usuario");
      }
    }
  }
}

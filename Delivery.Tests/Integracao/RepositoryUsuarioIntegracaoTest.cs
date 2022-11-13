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
    private SqlContextTest sqlContextTest;
    private IRepositoryUsuario repositoryUsuario;

    public RepositoryUsuarioIntegracaoTest()
    {
      sqlContextTest = new SqlContextTest();
      repositoryUsuario = new RepositoryUsuario(sqlContextTest.SqlContext);
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
        repositoryUsuario.Add(usuario);
      }
      catch
      {
        throw new Exception("Erro ao adicionar usuario no banco");
      }
      try
      {
        Usuario usuarioAdicionado = repositoryUsuario.GetById(usuario.Id);
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
      repositoryUsuario.Add(usuario);
      usuario.Senha = "87654321";
      try
      {
        repositoryUsuario.Update(usuario);
        var usuarioAtualizado = repositoryUsuario.GetById(usuario.Id);
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
      repositoryUsuario.Add(usuario);
      try
      {
        repositoryUsuario.Remove(usuario);
        var usuarioRemovido = repositoryUsuario.GetById(usuario.Id);
        Assert.Null(usuarioRemovido);
      }
      catch
      {
        throw new Exception("Erro ao remover usuario");
      }
    }
  }
}
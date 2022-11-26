using System;
using Bogus;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Entities;
using Delivery.Infrastructure.Data.Repositories;
using Xunit;

namespace Delivery.Tests
{
  public class RepositoryUsuarioIntegracaoServiceTest
  {
    private readonly SqlContextTest SqlContextTest;
    private readonly IRepositoryUsuario RepositoryUsuario;
    private readonly Faker<Usuario> UsuarioFaker;

    public RepositoryUsuarioIntegracaoServiceTest()
    {
      SqlContextTest = new SqlContextTest();
      RepositoryUsuario = new RepositoryUsuario(SqlContextTest.SqlContext);

      UsuarioFaker = new Faker<Usuario>("pt_BR")
        .RuleFor(e => e.Nome, e => e.Person.FullName)
        .RuleFor(e => e.Telefone, e => e.Phone.PhoneNumber("65#########"))
        .RuleFor(e => e.Email, e => e.Person.Email)
        .RuleFor(e => e.Senha, e => e.Internet.Password(10, false))
        .RuleFor(e => e.DataCadastro, e => e.Date.Recent());
    }

    [Fact]
    public void AddUsuario()
    {
      var usuario = UsuarioFaker.Generate();
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
      var usuario = UsuarioFaker.Generate();
      try
      {
        RepositoryUsuario.Add(usuario);
        usuario.Nome = "UpdateUsuario";
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
      var usuario = UsuarioFaker.Generate();
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

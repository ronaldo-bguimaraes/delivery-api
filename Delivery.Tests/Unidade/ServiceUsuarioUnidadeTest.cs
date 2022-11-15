using System;
using System.Collections.Generic;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Services;
using Delivery.Domain.Entities;
using Moq;
using Xunit;

namespace Delivery.Tests
{
  public class ServiceUsuarioUnidadeTest
  {
    [Fact]
    public void AddUsuarioValido()
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

      var repositoryMock = new Mock<IRepositoryUsuario>();

      repositoryMock.Setup(e => e.GetByEmail(It.IsAny<string>())).Returns<Usuario>(null);
      repositoryMock.Setup(e => e.GetByTelefone(It.IsAny<string>())).Returns<Usuario>(null);

      var serviceUsuario = new ServiceUsuario(repositoryMock.Object);
      serviceUsuario.Add(usuario);
    }

    [Fact]
    public void AddUsuarioInvalido()
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

      var repositoryMock = new Mock<IRepositoryUsuario>();

      repositoryMock.Setup(e => e.GetByEmail(It.IsAny<string>())).Returns(usuario);
      repositoryMock.Setup(e => e.GetByTelefone(It.IsAny<string>())).Returns(usuario);

      var serviceUsuario = new ServiceUsuario(repositoryMock.Object);

      Assert.Throws<Exception>(() => serviceUsuario.Add(usuario));
    }
  }
}

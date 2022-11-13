using System;
using System.Collections.Generic;
using Delivery.Application;
using Delivery.Application.Dtos;
using Delivery.Application.Interfaces.Mappers;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;
using Moq;
using Xunit;

namespace Delivery.Tests
{
  public class ApplicationServiceUsuarioTest
  {
    public Usuario GetUsuarioTest()
    {
      return new Usuario
      {
        Id = 1,
        Nome = "Usuario Teste",
        Telefone = "66999999999",
        Email = "usuario.teste@gmail.com",
        Senha = "teste12345",
        DataCadastro = DateTime.Now,
      };
    }

    [Fact]
    public void TelefoneSenhaCorretosTest()
    {
      var usuarioTeste = GetUsuarioTest();
      ICollection<Usuario> usuarios = new List<Usuario> { usuarioTeste };

      var serviceUsuarioMock = new Mock<IServiceUsuario>();
      serviceUsuarioMock.Setup(e => e.GetByTelefoneAndSenha(It.IsAny<string>(), It.IsAny<string>())).Returns(usuarioTeste);

      var mapperUsuarioMock = new Mock<IMapperUsuario>();

      var applicationServiceUsuario = new ApplicationServiceUsuario(serviceUsuarioMock.Object, mapperUsuarioMock.Object);

      var usuarioLogin = new UsuarioDto
      {
        Telefone = "66999999999",
        Senha = "teste12345",
      };

      var usuarioRetorno = applicationServiceUsuario.GetUsuarioWithClaim(usuarioLogin);

      Assert.Equal(usuarioTeste.Id, usuarioRetorno.Id);
    }

    [Fact]
    public void TelefoneSenhaIncorretosTest()
    {
      var serviceUsuarioMock = new Mock<IServiceUsuario>();
      serviceUsuarioMock.Setup(e => e.GetByTelefoneAndSenha(It.IsAny<string>(), It.IsAny<string>())).Returns<Usuario?>(null);

      var mapperUsuarioMock = new Mock<IMapperUsuario>();

      var applicationServiceUsuario = new ApplicationServiceUsuario(serviceUsuarioMock.Object, mapperUsuarioMock.Object);

      var usuarioLogin = new UsuarioDto
      {
        Telefone = "66999999999",
        Senha = "12345678", 
      };

      var usuarioRetorno = applicationServiceUsuario.GetUsuarioWithClaim(usuarioLogin);

      Assert.Null(usuarioRetorno);
    }
  }
}
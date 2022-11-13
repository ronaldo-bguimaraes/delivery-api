using Delivery.Api.Controllers;
using Delivery.Application;
using Delivery.Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Delivery.Tests
{
  public class UsuariosControllerUnidadeTest
  {
    [Fact]
    public void LoginCorretoTest()
    {
      var usuarioDto = new UsuarioDto();
      var serviceMock = new Mock<IApplicationServiceUsuario>();
      serviceMock.Setup(x => x.Authenticate(It.IsAny<UsuarioDto>())).Returns(usuarioDto);

      var usuariosController = new UsuariosController(serviceMock.Object);
      var result = usuariosController.Authenticate(usuarioDto);

      Assert.IsType<OkObjectResult>(result);
    }

    [Fact]
    public void LoginIncorretoTest()
    {
      var usuarioDto = new UsuarioDto();
      var serviceMock = new Mock<IApplicationServiceUsuario>();
      serviceMock.Setup(x => x.Authenticate(It.IsAny<UsuarioDto>())).Returns<UsuarioDto>(null);

      var usuariosController = new UsuariosController(serviceMock.Object);
      var result = usuariosController.Authenticate(usuarioDto);

      Assert.IsType<BadRequestObjectResult>(result);
    }
  }
}
using System;
using Bogus;
using Delivery.Application;
using Delivery.Application.Dtos;
using Delivery.Application.Interfaces.Mappers;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Core.Services;
using Delivery.Infrastructure.CrossCutting.Map;
using Delivery.Infrastructure.Data.Repositories;
using Xunit;

namespace Delivery.Tests
{
public class RepositoryUsuarioIntegracaoApplicationTest
{
  private readonly Faker<UsuarioDto> UsuarioFaker;
  private readonly SqlContextTest SqlContextTest;
  private readonly IRepositoryUsuario RepositoryUsuario;
  private readonly IServiceUsuario ServiceUsuario;
  private readonly IApplicationServiceUsuario ApplicationServiceUsuario;
  private readonly IMapperUsuario MapperUsuario;

  public RepositoryUsuarioIntegracaoApplicationTest()
  {
    SqlContextTest = new SqlContextTest();
    RepositoryUsuario = new RepositoryUsuario(SqlContextTest.SqlContext);
    ServiceUsuario = new ServiceUsuario(RepositoryUsuario);

    MapperUsuario = new MapperUsuario();
    ApplicationServiceUsuario = new ApplicationServiceUsuario(
      ServiceUsuario,
      MapperUsuario
    );

    UsuarioFaker = new Faker<UsuarioDto>("pt_BR")
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
      ApplicationServiceUsuario.Save(usuario);
    }
    catch
    {
      throw new Exception("Erro ao adicionar usuario no banco");
    }

    var entity = MapperUsuario.MapperDtoToEntity(usuario);

    var recuperado = RepositoryUsuario.GetByEmail(usuario.Email);

    Assert.True(entity.Equals(recuperado));
  }

  [Fact]
  public void UpdateUsuario()
  {
    var usuario = UsuarioFaker.Generate();
    try
    {
      ApplicationServiceUsuario.Save(usuario);

      var recuperado = RepositoryUsuario.GetByEmail(usuario.Email);
      var dto = MapperUsuario.MapperEntityToDto(recuperado);

      dto.Nome = "UpdateUsuario";
      ApplicationServiceUsuario.Save(dto);

      var atualizado = ServiceUsuario.GetById(dto.Id);

      var entity = MapperUsuario.MapperDtoToEntity(dto);

      Assert.True(entity.Equals(atualizado));
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
      ApplicationServiceUsuario.Save(usuario);
      var recuperado = RepositoryUsuario.GetByEmail(usuario.Email);
      var dto = MapperUsuario.MapperEntityToDto(recuperado);

      ApplicationServiceUsuario.Remove(dto);
      var removido = ServiceUsuario.GetById(dto.Id);
      Assert.Null(removido);
    }
    catch
    {
      throw new Exception("Erro ao remover usuario");
    }
  }

  [Fact]
  public void AuthenticateUsuarioCorreto()
  {
    var usuario = UsuarioFaker.Generate();

    try
    {
      ApplicationServiceUsuario.Save(usuario);
      var dto = ApplicationServiceUsuario.Authenticate(usuario);

      Assert.True(dto != null && dto.Token != null);
    }
    catch
    {
      throw new Exception("Erro ao autenticar usuario");
    }
  }

  [Fact]
  public void AuthenticateUsuarioIncorreto()
  {
    var usuario = UsuarioFaker.Generate();

    try
    {
      ApplicationServiceUsuario.Save(usuario);
      usuario.Senha = "12345678";

      var dto = ApplicationServiceUsuario.Authenticate(usuario);

      Assert.Null(dto);
    }
    catch
    {
      throw new Exception("Erro ao autenticar usuario");
    }
  }
}
}

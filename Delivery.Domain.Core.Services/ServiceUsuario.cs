using System;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Services
{
  public class ServiceUsuario : ServiceBase<Usuario>, IServiceUsuario

  {
    private readonly IRepositoryUsuario repositoryUsuario;

    public ServiceUsuario(IRepositoryUsuario _repositoryUsuario) : base(_repositoryUsuario)
    {
      repositoryUsuario = _repositoryUsuario;
    }

    public override void Add(Usuario usuario)
    {
      usuario.setDataCadastro();
      base.Add(usuario);
    }
  }
}

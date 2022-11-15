using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;
using System.Collections.Generic;

namespace Delivery.Domain.Core.Services
{
  public class ServiceEndereco : ServiceBase<Endereco>, IServiceEndereco
  {
    private readonly IRepositoryEndereco RepositoryEndereco;

    public ServiceEndereco(IRepositoryEndereco repositoryEndereco) : base(repositoryEndereco)
    {
      RepositoryEndereco = repositoryEndereco;
    }

    public ICollection<Endereco> GetByUsuarioId(int usuarioId)
    {
      return RepositoryEndereco.GetByUsuarioId(usuarioId);
    }
  }
}

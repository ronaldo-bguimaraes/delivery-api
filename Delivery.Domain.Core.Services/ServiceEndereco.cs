using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;
using System.Collections.Generic;

namespace Delivery.Domain.Core.Services
{
  public class ServiceEndereco : ServiceBase<Endereco>, IServiceEndereco
  {
    private readonly IRepositoryEndereco repositoryEndereco;

    public ServiceEndereco(IRepositoryEndereco _repositoryEndereco) : base(_repositoryEndereco)
    {
      repositoryEndereco = _repositoryEndereco;
    }

    // não está funcionando
    public ICollection<Endereco> GetByUsuarioId(int usuarioId)
    {
      return repositoryEndereco.GetByUsuarioId(usuarioId);
    }
  }
}

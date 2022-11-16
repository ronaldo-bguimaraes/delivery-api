using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Services
{
  public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
  {
    private readonly IRepositoryCliente RepositoryCliente;

    public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
    {
      RepositoryCliente = repositoryCliente;
    }

    public Cliente GetByUsuarioId(int usuarioId)
    {
      return RepositoryCliente.GetByUsuarioId(usuarioId);
    }
  }
}

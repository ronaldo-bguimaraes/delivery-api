using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Services
{
  public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
  {
    private readonly IRepositoryCliente repositoryCliente;

    public ServiceCliente(IRepositoryCliente _repositoryCliente) : base(_repositoryCliente)
    {
      repositoryCliente = _repositoryCliente;
    }

    public Cliente GetByUsuarioId(int usuarioId)
    {
      return repositoryCliente.GetByUsuarioId(usuarioId);
    }
  }
}

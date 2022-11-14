using Delivery.Domain.Entities;
using System.Collections.Generic;

namespace Delivery.Domain.Core.Interfaces.Services
{
  public interface IServiceEndereco : IServiceBase<Endereco>
  {
    ICollection<Endereco> GetByUsuarioId(int usuarioId);
  }
}

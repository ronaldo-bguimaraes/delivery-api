using Delivery.Domain.Entities;
using System.Collections.Generic;

namespace Delivery.Domain.Core.Interfaces.Services
{
  public interface IServiceEndereco : IServiceBase<Endereco> {
    IEnumerable<Endereco> GetByUsuarioId(int usuarioId);
  }
}

using Delivery.Domain.Entities;
using System.Collections.Generic;

namespace Delivery.Domain.Core.Interfaces.Repositories
{
  public interface IRepositoryEndereco : IRepositoryBase<Endereco>
  {
    ICollection<Endereco> GetByUsuarioId(int usuarioId);
  }
}

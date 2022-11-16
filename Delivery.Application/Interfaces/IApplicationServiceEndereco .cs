using Delivery.Application.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceEndereco : IApplicationServiceBase<EnderecoDto>
  {
    public ICollection<EnderecoDto> GetByUsuarioId(int id);
  }
}

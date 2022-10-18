using Delivery.Application.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceEntregador
  {
    void Save(EntregadorDto entregadorDto);

    void Remove(EntregadorDto entregadorDto);

    ICollection<EntregadorDto> GetAll();

    EntregadorDto GetById(int id);

    EntregadorDto GetByUsuarioId(int id);

  }
}

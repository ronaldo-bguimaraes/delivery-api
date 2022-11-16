using Delivery.Application.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceEntregador
  {
    public void Save(EntregadorDto entregadorDto);

    public void Remove(EntregadorDto entregadorDto);

    public ICollection<EntregadorDto> GetAll();

    public EntregadorDto GetById(int id);

    public EntregadorDto GetByUsuarioId(int id);

  }
}

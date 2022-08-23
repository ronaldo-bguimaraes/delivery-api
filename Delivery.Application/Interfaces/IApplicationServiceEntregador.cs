using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
    public interface IApplicationServiceEntregador
    {
        void Add(EntregadorDto entregadorDto);

        void Update(EntregadorDto entregadorDto);

        void Remove(EntregadorDto entregadorDto);

        IEnumerable<EntregadorDto> GetAll();

        EntregadorDto GetById(int id);

        EntregadorDto GetByUsuarioId(int id);
       
    }
}

using Delivery.Application.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationPagamento
  {
    void Save(PagamentoDto pagamentoDto);

    void Remove(PagamentoDto pagamentoDto);

    ICollection<PagamentoDto> GetAll();

    PagamentoDto GetById(int id);
  }
}

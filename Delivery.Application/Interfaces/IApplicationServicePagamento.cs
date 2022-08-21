using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationPagamento
  {

    void Add(PagamentoDto pagamentoDto);

    void Update(PagamentoDto pagamentoDto);

    void Remove(PagamentoDto pagamentoDto);

    IEnumerable<PagamentoDto> GetAll();

   PagamentoDto GetById(int id);
  }
}

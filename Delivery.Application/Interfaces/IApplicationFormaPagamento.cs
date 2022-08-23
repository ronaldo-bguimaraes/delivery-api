using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationFormaPagamento
  {
    void Add(FormaPagamentoDto formaPagamentoDto);

    void Update(FormaPagamentoDto formaPagamentoDto);

    void Remove(FormaPagamentoDto formaPagamentoDto);

    IEnumerable<FormaPagamentoDto> GetAll();

    FormaPagamentoDto GetById(int id);

    FormaPagamentoDto GetByUsuarioId(int id);

  }
}

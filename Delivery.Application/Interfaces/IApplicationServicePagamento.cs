using Delivery.Application.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationPagamento
  {
    public void Save(PagamentoDto pagamentoDto);

    public void Remove(PagamentoDto pagamentoDto);

    public ICollection<PagamentoDto> GetAll();

    public PagamentoDto GetById(int id);
  }
}

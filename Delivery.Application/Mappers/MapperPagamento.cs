using Delivery.Domain.Entities;
using Delivery.Application.Dtos;
using System.Collections.Generic;
using System.Linq;
using Delivery.Application.Interfaces.Mappers;

namespace Delivery.Infrastructure.CrossCutting.Map
{
  public class MapperPagamento : IMapperPagamento 
  {

    public Pagamento MapperDtoToEntity(PagamentoDto pagamentoDto)
    {
      var pagamento = new Pagamento
      {
         Id = pagamentoDto.Id,
         FormaPagamento = pagamentoDto.FormaPagamento,
         DataPagamento = pagamentoDto.DataPagamento.ToUniversalTime(),
         Valor = pagamentoDto.Valor        
      };
      return pagamento;
    }

    public PagamentoDto MapperEntityToDto(Pagamento pagamento)
    {
      var pagamentoDto = new PagamentoDto
      {
       Id = pagamento.Id,
       DataPagamento = pagamento.DataPagamento.ToUniversalTime(),
       Valor = pagamento.Valor,
       FormaPagamento = pagamento.FormaPagamento
      };
      return pagamentoDto;
    }

    public ICollection<PagamentoDto> MapperEntitiesToDtos(ICollection<Pagamento> pagamentos)
    {
      var pagamentoDtos = pagamentos.Select(pagamento => new PagamentoDto
      {
          Id = pagamento.Id,
          DataPagamento = pagamento.DataPagamento.ToUniversalTime(),
          Valor = pagamento.Valor,
          FormaPagamento = pagamento.FormaPagamento
      });
      return pagamentoDtos.ToList();
    }

    public ICollection<Pagamento> MapperDtosToEntities(ICollection<PagamentoDto> pagamentoDtos)
    {
      var pagamentos = pagamentoDtos.Select(pagamentoDto => new Pagamento
      {
          Id = pagamentoDto.Id,
          FormaPagamento = pagamentoDto.FormaPagamento,
          DataPagamento = pagamentoDto.DataPagamento.ToUniversalTime(),
          Valor = pagamentoDto.Valor
      });
      return pagamentos.ToList();
    }
  }
}

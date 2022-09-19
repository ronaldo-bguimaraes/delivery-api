using Delivery.Domain.Entities;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Infrastructure.CrossCutting.Map
{
  public class MapperVenda : IMapperVenda
  {
    public Venda MapperDtoToEntity(VendaDto vendaDto)
    {
      var venda = new Venda
      {
          Id = vendaDto.Id,
          ClienteId = vendaDto.ClienteId,
          Condicao = vendaDto.Condicao,
          DataVenda = vendaDto.DataVenda,
          EntregadorId = vendaDto.EntregadorId,
          Frete = vendaDto.Frete,
          PagamentoId = vendaDto.PagamentoId,
          Subtotal = vendaDto.Subtotal,
          Total = vendaDto.Total,
      };
      return venda;
    }

    public VendaDto MapperEntityToDto(Venda venda)
    {
      var vendaDto = new VendaDto
      {
          Id = venda.Id,
          ClienteId = venda.ClienteId,
          Condicao = venda.Condicao,
          DataVenda = venda.DataVenda,
          EntregadorId = venda.EntregadorId,
          Frete = venda.Frete,
          PagamentoId = venda.PagamentoId,
          Subtotal = venda.Subtotal,
          Total = venda.Total,
      };
      return vendaDto;
    }

    public IEnumerable<VendaDto> MapperEntitiesToDtos(IEnumerable<Venda> clientes)
    {
      var clienteDtos = clientes.Select(vendaDto => new VendaDto
      {
          Id = vendaDto.Id,
          ClienteId = vendaDto.ClienteId,
          Condicao = vendaDto.Condicao,
          DataVenda = vendaDto.DataVenda,
          EntregadorId = vendaDto.EntregadorId,
          Frete = vendaDto.Frete,
          PagamentoId = vendaDto.PagamentoId,
          Subtotal = vendaDto.Subtotal,
          Total = vendaDto.Total,
      });
      return clienteDtos;
    }

    public IEnumerable<Venda> MapperDtosToEntities(IEnumerable<VendaDto> clienteDtos)
    {
      var vendas = clienteDtos.Select(venda => new Venda
      {
          Id = venda.Id,
          ClienteId = venda.ClienteId,
          Condicao = venda.Condicao,
          DataVenda = venda.DataVenda,
          EntregadorId = venda.EntregadorId,
          Frete = venda.Frete,
          PagamentoId = venda.PagamentoId,
          Subtotal = venda.Subtotal,
          Total = venda.Total,
      });
      return vendas;
    }
  }
}

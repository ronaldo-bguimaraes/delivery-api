using Delivery.Domain.Entities;
using Delivery.Application.Dtos;
using System.Collections.Generic;
using System.Linq;
using Delivery.Application.Interfaces.Mappers;

namespace Delivery.Infrastructure.CrossCutting.Map
{
  public class MapperVenda : IMapperVenda
  {
    private readonly IMapperItemProduto mapperItemProduto;

    public MapperVenda(IMapperItemProduto _mapperItemProduto)
    {
      mapperItemProduto = _mapperItemProduto;
    }

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
        ItensProduto = mapperItemProduto.MapperDtosToEntities(vendaDto.ItensProduto)
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
        ItensProduto = mapperItemProduto.MapperEntitiesToDtos(venda.ItensProduto)
      };
      return vendaDto;
    }

    public ICollection<VendaDto> MapperEntitiesToDtos(ICollection<Venda> vendas)
    {
      var vendaDtos = vendas.Select(venda => new VendaDto
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
        ItensProduto = mapperItemProduto.MapperEntitiesToDtos(venda.ItensProduto)
      });
      return vendaDtos.ToList();
    }

    public ICollection<Venda> MapperDtosToEntities(ICollection<VendaDto> vendaDtos)
    {
      var vendas = vendaDtos.Select(vendaDto => new Venda
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
        ItensProduto = mapperItemProduto.MapperDtosToEntities(vendaDto.ItensProduto)
      });
      return vendas.ToList();
    }
  }
}

using RestApiModeloDDD.Core.Interfaces.Services;
using RestApiModeloDDD.Dtos;
using RestAPiModeloDDD.Infrastructure.CrossCutting.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Application.Mappers
{
    public class ApplicationServiceProduto : IApplicationServiceProduto { 

        private readonly IserviceProduto serviceProduto;
        private readonly IMapperProduto mapperProduto;
        public ApplicationServiceProduto(IserviceProduto _serviceproduto
                                       , IMapperProduto _mapperProduto)
        {
           serviceProduto = _serviceproduto;
            mapperProduto = _mapperProduto;
        }

        public void Add(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produto = serviceProduto.GetAll();
            return mapperProduto.MapperlistClientesDto(produto);
        }

        public ProdutoDto GetById(int id)
        {
            var produto = serviceProduto.GetTById(id);
            return mapperProduto.MapperEntityToDto(produto);
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produto = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var cliente = mapperProduto.MapperDtoToEntity(produtoDto);
            serviceProduto.Update(cliente);
        }
    }
}

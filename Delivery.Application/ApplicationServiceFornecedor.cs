using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Dtos;
using Delivery.Infrastructure.CrossCutting.Interface;
using System.Collections.Generic;

namespace Delivery.Application
{
  public class ApplicationServiceFornecedor : IApplicationServiceFornecedor
  {
    private readonly IServiceFornecedor serviceFornecedor;
    private readonly IMapperFornecedor mapperFornecedor;

    public ApplicationServiceFornecedor(IServiceFornecedor _serviceFornecedor, IMapperFornecedor _mapperFornecedor)
    {
      serviceFornecedor = _serviceFornecedor;
      mapperFornecedor = _mapperFornecedor;
    }

    public void Save(FornecedorDto fornecedorDto)
    {
      var fornecedor = mapperFornecedor.MapperDtoToEntity(fornecedorDto);
      if (serviceFornecedor.GetById(fornecedor.Id) == null)
      {
        serviceFornecedor.Add(fornecedor);
      }
      else
      {
        serviceFornecedor.Update(fornecedor);
      }
    }

    public IEnumerable<FornecedorDto> GetAll()
    {
      var fornecedores = serviceFornecedor.GetAll();
      return mapperFornecedor.MapperEntitiesToDtos(fornecedores);
    }

    public FornecedorDto GetById(int id)
    {
      var fornecedor = serviceFornecedor.GetById(id);
      return mapperFornecedor.MapperEntityToDto(fornecedor);
    }

    public FornecedorDto GetByUsuarioId(int id)
    {
      var fornecedor = serviceFornecedor.GetByUsuarioId(id);
      return mapperFornecedor.MapperEntityToDto(fornecedor);
    }

    public void Remove(FornecedorDto fornecedorDto)
    {
      var fornecedor = mapperFornecedor.MapperDtoToEntity(fornecedorDto);
      serviceFornecedor.Remove(fornecedor);
    }
  }
}

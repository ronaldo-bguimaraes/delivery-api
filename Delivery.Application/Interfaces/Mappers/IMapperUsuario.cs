using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Infrastructure.CrossCutting.Interface
{
  public interface IMapperUsuario
  {  //MapeamentoDTO para entidade
    Usuario MapperDtoToEntity(UsuarioDto clientedto);
    IEnumerable<UsuarioDto> MapperEntitiesToDtos(IEnumerable<Usuario> produto);
    UsuarioDto MapperEntityToDto(Usuario produto);
  }
}

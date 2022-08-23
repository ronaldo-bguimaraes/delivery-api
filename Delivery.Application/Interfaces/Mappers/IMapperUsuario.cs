using Delivery.Domain.Entities;
using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Infrastructure.CrossCutting.Interface
{
  public interface IMapperUsuario //MapeamentoDTO para entidade
  {
    Usuario MapperDtoToEntity(UsuarioDto usuariodto);
    IEnumerable<UsuarioDto> MapperEntitiesToDtos(IEnumerable<Usuario> usuarios);
    UsuarioDto MapperEntityToDto(Usuario usuario);
  }
}

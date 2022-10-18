using Delivery.Application.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceUsuario
  {
    void Save(UsuarioDto usuarioDto);

    void Remove(UsuarioDto usuarioDto);

    ICollection<UsuarioDto> GetAll();

    UsuarioDto Authenticate(UsuarioDto usuarioDto);

    UsuarioDto GetById(int id);
  }
}

using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceUsuario
  {

    void Add(UsuarioDto usuarioDto);

    void Update(UsuarioDto usuarioDto);

    void Remove(UsuarioDto usuarioDto);

    IEnumerable<UsuarioDto> GetAll();

    UsuarioDto Authenticate(UsuarioDto usuarioDto);

    UsuarioDto GetById(int id);
  }
}

using Delivery.Application.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceUsuario
  {
    public void Save(UsuarioDto usuarioDto);

    public void Remove(UsuarioDto usuarioDto);

    public ICollection<UsuarioDto> GetAll();

    public UsuarioDto Authenticate(UsuarioDto usuarioDto);

    public UsuarioDto GetById(int id);
  }
}

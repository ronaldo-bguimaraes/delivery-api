using Delivery.Application.Dtos;

namespace Delivery.Application
{
  public interface IApplicationServiceUsuario : IApplicationServiceBase<UsuarioDto>
  {
    public UsuarioDto Authenticate(UsuarioDto usuarioDto);
  }
}

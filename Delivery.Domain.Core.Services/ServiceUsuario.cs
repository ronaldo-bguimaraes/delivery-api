using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Delivery.Domain.Core.Interfaces.Repositories;
using Delivery.Domain.Core.Interfaces.Services;
using Delivery.Domain.Entities;

namespace Delivery.Domain.Core.Services
{
  public class ServiceUsuario : ServiceBase<Usuario>, IServiceUsuario

  {
    private readonly IRepositoryUsuario repositoryUsuario;

    public ServiceUsuario(IRepositoryUsuario _repositoryUsuario) : base(_repositoryUsuario)
    {
      repositoryUsuario = _repositoryUsuario;
    }

    public static string CreateMD5Hash(string text)
    {
      MD5 md5 = MD5.Create();
      byte[] inputBytes = Encoding.ASCII.GetBytes(text);
      byte[] hashBytes = md5.ComputeHash(inputBytes);
      var hash = hashBytes.Select(e => e.ToString("X2"));
      return string.Join("", hash);
    }

    public bool ValidaSenha(string senhaFornecida, string senhaSalva)
    {
      return CreateMD5Hash(senhaFornecida) == senhaSalva;
    }

    public Usuario GetByEmailAndSenha(string email, string senha)
    {
      var usuario = repositoryUsuario.GetByEmail(email);
      if (usuario != null && ValidaSenha(senha, usuario.Senha))
      {
        return usuario;
      }
      return null;
    }

    public Usuario GetByTelefoneAndSenha(string telefone, string senha)
    {
      var usuario = repositoryUsuario.GetByTelefone(telefone);
      if (usuario != null && ValidaSenha(senha, usuario.Senha))
      {
        return usuario;
      }
      return null;
    }
  }
}

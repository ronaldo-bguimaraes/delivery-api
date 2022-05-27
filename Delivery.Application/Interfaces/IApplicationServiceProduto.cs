using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceProduto
  {

    void Add(UsuarioDto produtoDto);

    void Update(UsuarioDto produtoDto);

    void Remove(UsuarioDto produtoDto);

    IEnumerable<UsuarioDto> GetAll();

    UsuarioDto GetById(int id);
  }
}

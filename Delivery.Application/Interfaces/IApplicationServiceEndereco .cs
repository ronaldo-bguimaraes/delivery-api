using Delivery.Application.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceEndereco
  {
    void Save(EnderecoDto enderecoDto);

    void Remove(EnderecoDto enderecoDto);

    ICollection<EnderecoDto> GetAll();

    EnderecoDto GetById(int id);

    ICollection<EnderecoDto> GetByUsuarioId(int usuarioId);
  }
}

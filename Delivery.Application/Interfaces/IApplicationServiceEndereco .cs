using Delivery.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceEndereco
  {
    void Add(EnderecoDto enderecoDto);

    void Update(EnderecoDto enderecoDto);

    void Remove(EnderecoDto enderecoDto);

    IEnumerable<EnderecoDto> GetAll();

    EnderecoDto GetById(int id);

    IEnumerable<EnderecoDto> GetByUsuarioId(int id);
  }
}

using Delivery.Application.Dtos;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceEndereco
  {
    public void Save(EnderecoDto enderecoDto);

    public void Remove(EnderecoDto enderecoDto);

    public ICollection<EnderecoDto> GetAll();

    public EnderecoDto GetById(int id);

    public ICollection<EnderecoDto> GetByUsuarioId(int id);
  }
}

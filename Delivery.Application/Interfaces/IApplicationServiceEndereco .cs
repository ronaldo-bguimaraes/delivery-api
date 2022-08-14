using Delivery.Dtos;
using System;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceEndereco
  {
    [Obsolete("Add is deprecated, please use Save instead.")]
    void Add(EnderecoDto enderecoDto);

    void Save(EnderecoDto enderecoDto);

    [Obsolete("Update is deprecated, please use Save instead.")]
    void Update(EnderecoDto enderecoDto);

    void Remove(EnderecoDto enderecoDto);

    IEnumerable<EnderecoDto> GetAll();

    EnderecoDto GetById(int id);

    IEnumerable<EnderecoDto> GetByUsuarioId(int id);

  }
}

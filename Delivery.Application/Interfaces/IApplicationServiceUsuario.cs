﻿using Delivery.Dtos;
using System;
using System.Collections.Generic;

namespace Delivery.Application
{
  public interface IApplicationServiceUsuario
  {
<<<<<<< Updated upstream

=======
    [Obsolete("Add is deprecated, please use Save instead.")]
>>>>>>> Stashed changes
    void Add(UsuarioDto usuarioDto);

    void Save(UsuarioDto usuarioDto);

    [Obsolete("Update is deprecated, please use Save instead.")]
    void Update(UsuarioDto usuarioDto);

    void Remove(UsuarioDto usuarioDto);

    IEnumerable<UsuarioDto> GetAll();

    UsuarioDto Authenticate(UsuarioDto usuarioDto);

    UsuarioDto GetById(int id);
  }
}

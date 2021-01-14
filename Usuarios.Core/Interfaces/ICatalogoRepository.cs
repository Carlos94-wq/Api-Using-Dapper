using System;
using System.Collections.Generic;
using System.Text;
using Usuarios.Core.Entities;

namespace Usuarios.Core.Interfaces
{
    public interface ICatalogoRepository
    {
        IEnumerable<Rol> Roles();
        IEnumerable<Estatus> Estatus();

    }
}

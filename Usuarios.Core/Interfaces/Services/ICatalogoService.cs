using System;
using System.Collections.Generic;
using System.Text;
using Usuarios.Core.Entities;

namespace Usuarios.Core.Interfaces.Services
{
    public interface ICatalogoService
    {
        IEnumerable<Rol> Roles();
        IEnumerable<Estatus> Estatus();
    }
}

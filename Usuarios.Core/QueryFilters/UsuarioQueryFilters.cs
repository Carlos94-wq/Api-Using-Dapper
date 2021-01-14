using System;
using System.Collections.Generic;
using System.Text;

namespace Usuarios.Core.QueryFilters
{
    public class UsuarioQueryFilters
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public int? IdEstatus { get; set; }
        public int? IdRol { get; set; }
    }
}

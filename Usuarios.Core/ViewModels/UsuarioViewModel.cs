using System;
using System.Collections.Generic;
using System.Text;

namespace Usuarios.Core.ViewModels
{
    public class UsuarioViewModel
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Estatus { get; set; }
        public string Rol { get; set; }
    }
}

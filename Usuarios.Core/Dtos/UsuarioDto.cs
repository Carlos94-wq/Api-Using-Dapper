using System;
using System.Collections.Generic;
using System.Text;

namespace Usuarios.Core.Dtos
{
    public class UsuarioDto
    {
       
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public int IdEstatus { get; set; }
        public int IdRol { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificiacion { get; set; }
        public DateTime FechaBaja { get; set; }
    }
}

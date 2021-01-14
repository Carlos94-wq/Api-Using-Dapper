using System;
using System.Collections.Generic;
using System.Text;

namespace Usuarios.Core.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Contrasenia { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaModificiacion { get; set; }
        public DateTime FechaBaja { get; set; }

        public Estatus Estatus { get; set; }
        public Rol Rol { get; set; }

        public Usuario()
        {
            this.Rol = new Rol();
            this.Estatus = new Estatus();
        }
    }
}

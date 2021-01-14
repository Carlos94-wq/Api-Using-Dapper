using System;
using System.Collections.Generic;
using System.Text;
using Usuarios.Core.Entities;
using Usuarios.Core.Interfaces;
using Usuarios.Core.Interfaces.Services;

namespace Usuarios.Core.Services
{
    public class CatalogoService : ICatalogoService
    {
        private readonly ICatalogoRepository repository;

        public CatalogoService(ICatalogoRepository repository)
        {
            this.repository = repository;
        }
        public IEnumerable<Estatus> Estatus()
        {
            return this.repository.Estatus();
        }

        public IEnumerable<Rol> Roles()
        {
            return this.repository.Roles();
        }
    }
}

using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Usuarios.Core.Entities;
using Usuarios.Core.Interfaces;

namespace Usuarios.Infra.Repositories
{
    public class CatalogoRepository : ICatalogoRepository
    {
        private readonly IDbConnection db;

        public CatalogoRepository( IDbConnection db  )
        {
            this.db = db;
        }

        public IEnumerable<Estatus> Estatus()
        {
            return this.db.Query<Estatus>(sql: "spCatalogos", commandType: CommandType.StoredProcedure, param: new
            {
                Accion = 1
            });
        }

        public IEnumerable<Rol> Roles()
        {
            return this.db.Query<Rol>(sql: "spCatalogos", commandType: CommandType.StoredProcedure, param: new
            {
                Accion = 2
            });
        }
    }
}

using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Core.Entities;
using Usuarios.Core.Interfaces;
using Usuarios.Core.ViewModels;

namespace Usuarios.Infra.Repositories
{
    public class AuthRepository : IAuthRespository
    {
        private readonly IDbConnection db;

        public AuthRepository(IDbConnection db)
        {
            this.db = db;
        }

        public async Task<Usuario> Login(UserCredentials crendentials)
        {
            #region Params
            var parametros = new
            {
                Accion = 1,
                Correo = crendentials.Correo,
                Contrasenia = crendentials.Contrasenia
            };
            #endregion

            var user = await this.db.QueryAsync<Usuario, Rol, Usuario>(
                sql: "spUsuario", 
                commandType: CommandType.StoredProcedure, 
                param: parametros,
                map: (u, r) =>
                {
                    u.Rol = r;
                    return u;
                }, 
                splitOn: "IdRol" );

            return user.FirstOrDefault();
        }
    }
}

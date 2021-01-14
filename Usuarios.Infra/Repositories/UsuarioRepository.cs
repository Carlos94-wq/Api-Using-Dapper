using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Core.Dtos;
using Usuarios.Core.Entities;
using Usuarios.Core.Interfaces;
using Usuarios.Core.QueryFilters;
using Usuarios.Core.ViewModels;

namespace Usuarios.Infra.Repositories
{
    public class UsuarioRepository : IUsurioRepository
    {
        private readonly IDbConnection db;

        public UsuarioRepository(IDbConnection connection)
        {
            this.db = connection;
        }

        public IEnumerable<UsuarioViewModel> GetAll(UsuarioQueryFilters filters)
        {
            #region Parametros
            var parametros = new
            {
                Accion = 2, // <-- Filtro de usuarios
                Nombre = filters.Nombre, 
                Apellidos = filters.Apellidos,
                Correo = filters.Correo,
                IdRol = filters.IdRol,
                IdEstatus = filters.IdEstatus
            };
            #endregion

            using (var con = this.db)
            {
                con.Open();

                var query = this.db.Query<UsuarioViewModel>(
                   sql: "spUsuario",
                   commandType: CommandType.StoredProcedure,
                   param: parametros
               ).ToList();

                return query;
            }
        }

        public async Task<Usuario> Usuario(int id)
        {
            #region Parametros
            var parametros = new
            {
                Accion = 6,
                IdUsuario = id
            };

            #endregion

            using (var con = this.db)
            {
                var User = await this.db.QueryAsync<Usuario, Rol, Estatus, Usuario>(
                   sql: "spUsuario",
                   map: (u, r, e) =>
                   {
                       u.Rol = r;
                       u.Estatus = e;
                       
                       return u;
                   },
                   splitOn: "IdRol, IdEstatus",
                   commandType: CommandType.StoredProcedure,
                   param: parametros

                );

                return User.FirstOrDefault();
            }
        }
         
        public async Task<int> Add(UsuarioDto usuario)
        {
            #region Parametros
            var parametros = new
            {
                Accion = 3,
                Nombre = usuario.Nombre,
                Apellidos = usuario.Apellidos,
                Correo = usuario.Correo,
                Contrasenia = usuario.Contrasenia,
                IdRol = usuario.IdRol
            }; 
            #endregion

            using (this.db)
            {
                var add = await this.db.ExecuteAsync(

                    sql: "spUsuario",
                    commandType: CommandType.StoredProcedure,
                    param: parametros

                );

                return add;
            }
        }

        public async Task<int> Delete(int id)
        {
            #region Parametros
            var parametros = new
            {
                Accion = 4,
                IdUsuario = id
            }; 
            #endregion

            var delete = await this.db.ExecuteAsync(
                sql: "spUsuario",
                commandType: CommandType.StoredProcedure,
                param: parametros
            );

            return delete;
        }

        public async Task<int> Update(UsuarioDto usuario)
        {
            #region Parametros
            var parametros = new
            {
                Accion = 5,
                IdUsuario = usuario.IdUsuario,
                Nombre = usuario.Nombre,
                Apellidos = usuario.Apellidos,
                Correo = usuario.Correo,
                Contrasenia = usuario.Contrasenia,
            };
            #endregion

            using (this.db)
            {
                var add = await this.db.ExecuteAsync(

                    sql: "spUsuario",
                    commandType: CommandType.StoredProcedure,
                    param: parametros

                );

                return add;
            }
        }
    }
}

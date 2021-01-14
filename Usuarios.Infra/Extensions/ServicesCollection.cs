using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Usuarios.Core.Interfaces;
using Usuarios.Core.Interfaces.Services;
using Usuarios.Core.Services;
using Usuarios.Infra.Repositories;

namespace Usuarios.Infra.Extensions
{
    public static class ServicesCollection
    {
        //Conexion desde appsetings.json
        public static IServiceCollection AddContext(this IServiceCollection services, IConfiguration configuration) 
        {
            string ConnectionStrings = configuration.GetConnectionString("DbConnection");
            services.AddTransient<IDbConnection>(option => new SqlConnection(ConnectionStrings));

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUsurioRepository, UsuarioRepository>();
            services.AddTransient<IUsuarioService, UsuarioServices>();

            services.AddTransient<ICatalogoRepository, CatalogoRepository>();
            services.AddTransient<ICatalogoService, CatalogoService>();

            services.AddTransient<IAuthRespository, AuthRepository>();
            services.AddTransient<IAuthService, AuthService>();

            return services;
        }
    }
}

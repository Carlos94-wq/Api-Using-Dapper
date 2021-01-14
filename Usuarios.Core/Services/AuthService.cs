using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Core.Entities;
using Usuarios.Core.Interfaces;
using Usuarios.Core.Interfaces.Services;
using Usuarios.Core.ViewModels;

namespace Usuarios.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRespository auth;

        public AuthService(IAuthRespository auth)
        {
            this.auth = auth;
        }

        public async Task<Usuario> Login(UserCredentials crendentials)
        {
            return await this.auth.Login(crendentials);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Core.Entities;
using Usuarios.Core.ViewModels;

namespace Usuarios.Core.Interfaces.Services
{
    public interface IAuthService
    {
        Task<Usuario> Login(UserCredentials crendentials);
    }
}

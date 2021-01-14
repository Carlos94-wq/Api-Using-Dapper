using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Core.Entities;
using Usuarios.Core.ViewModels;

namespace Usuarios.Core.Interfaces
{
   
    public interface IAuthRespository
    {
        Task<Usuario> Login(UserCredentials crendentials);
    }
}

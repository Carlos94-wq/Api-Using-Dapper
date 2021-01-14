using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Core.Dtos;
using Usuarios.Core.Entities;
using Usuarios.Core.QueryFilters;
using Usuarios.Core.ViewModels;

namespace Usuarios.Core.Interfaces.Services
{
    public interface IUsuarioService
    {
        IEnumerable<UsuarioViewModel> GetAll(UsuarioQueryFilters filters);
        Task<Usuario> Usuario(int id);
        Task<bool> Add(UsuarioDto usuario);
        Task<bool> Update(UsuarioDto usuario);
        Task<bool> Delete(int id);
    }
}

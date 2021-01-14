using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Core.Dtos;
using Usuarios.Core.Entities;
using Usuarios.Core.QueryFilters;
using Usuarios.Core.ViewModels;

namespace Usuarios.Core.Interfaces
{
    public interface IUsurioRepository
    {
        IEnumerable<UsuarioViewModel> GetAll(UsuarioQueryFilters filters);
        Task<Usuario> Usuario(int id);
        Task<int> Add(UsuarioDto usuario);
        Task<int> Update(UsuarioDto usuario);
        Task<int> Delete(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Usuarios.Core.Dtos;
using Usuarios.Core.Entities;
using Usuarios.Core.Interfaces;
using Usuarios.Core.Interfaces.Services;
using Usuarios.Core.QueryFilters;
using Usuarios.Core.ViewModels;

namespace Usuarios.Core.Services
{
    public class UsuarioServices : IUsuarioService
    {
        private readonly IUsurioRepository repository;

        public UsuarioServices(IUsurioRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<UsuarioViewModel> GetAll(UsuarioQueryFilters filters)
        {
            return this.repository.GetAll(filters);
        }

        public async Task<Usuario> Usuario(int id)
        {
            return await this.repository.Usuario(id);
        }

        public async Task<bool> Add(UsuarioDto usuario)
        {
            var isAdded = await this.repository.Add(usuario);
            return isAdded > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var delete = await this.repository.Delete(id);
            return delete > 0;
        }

        public async Task<bool> Update(UsuarioDto usuario)
        {
            var delete = await this.repository.Update(usuario);
            return delete > 0;
        }

       
    }
}

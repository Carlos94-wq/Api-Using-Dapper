using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuarios.Api.Responses;
using Usuarios.Core.Dtos;
using Usuarios.Core.Entities;
using Usuarios.Core.Interfaces.Services;
using Usuarios.Core.QueryFilters;
using Usuarios.Core.ViewModels;

namespace Usuarios.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService service;

        public UsuarioController(IUsuarioService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] UsuarioQueryFilters filters)
        {
            var All = this.service.GetAll(filters);
            var response = new ApiResponse<IEnumerable<UsuarioViewModel>>(All);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var All = await this.service.Usuario(id);
            var response = new ApiResponse<Usuario>(All);

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UsuarioDto dto)
        {
            var add = await this.service.Add(dto);
            var response = new ApiResponse<bool>(add);

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UsuarioDto dto)
        {
            var Update = await this.service.Update(dto);
            var response = new ApiResponse<bool>(Update);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var All = await this.service.Delete(id);
            var response = new ApiResponse<bool>(All);

            return Ok(response);
        }
    }
}

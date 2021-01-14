using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuarios.Api.Responses;
using Usuarios.Core.Entities;
using Usuarios.Core.Interfaces.Services;

namespace Usuarios.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CatalogoController : ControllerBase
    {
        private readonly ICatalogoService service;

        public CatalogoController(ICatalogoService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult GetEstatus()
        {
            var Estatus = this.service.Estatus();
            var response = new ApiResponse<IEnumerable<Estatus>>(Estatus);

            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetRoles()
        {
            var Rol = this.service.Roles();
            var response = new ApiResponse<IEnumerable<Rol>>(Rol);

            return Ok(response);
        }
    }
}

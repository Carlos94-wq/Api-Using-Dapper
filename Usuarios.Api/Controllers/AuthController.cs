using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Usuarios.Api.Responses;
using Usuarios.Core.Entities;
using Usuarios.Core.Interfaces;
using Usuarios.Core.ViewModels;

namespace Usuarios.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRespository respository;

        public AuthController(IAuthRespository respository)
        {
            this.respository = respository;
        }

        [HttpPost]
        public async Task<IActionResult> LogIn([FromBody] UserCredentials user)
        {
            var usuario = await this.respository.Login(user);
            var response = new ApiResponse<Usuario>(usuario);

            return Ok(response);
        }
    }
}

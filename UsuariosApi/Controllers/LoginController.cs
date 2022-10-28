using FluentResults;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos.Requests;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private LoginService _loginservice;

        public LoginController(LoginService loginservice)
        {
            _loginservice = loginservice;
        }

        [HttpPost]
        public IActionResult LogaUsuario(LoginRequest request)
        {
            Result resultado = _loginservice.LogaUsuario(request);
            if (resultado.IsFailed)
                return Unauthorized(resultado.Errors);
            return Ok();
        }
    }
}
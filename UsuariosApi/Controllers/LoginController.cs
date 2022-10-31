﻿using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
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
            var resultado = _loginservice.LogaUsuario(request);
            if (resultado.IsFailed)
                return Unauthorized(resultado.Errors.FirstOrDefault());
            return Ok(resultado.Successes.FirstOrDefault());
        }
    }
}
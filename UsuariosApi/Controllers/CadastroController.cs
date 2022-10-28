using FluentResults;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Services;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : ControllerBase
    {
        private CadastroService _cadastroService;

        public CadastroController(CadastroService service)
        {
            _cadastroService = service;
        }

        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDto createDto)
        {
            Result resultado = _cadastroService.CadastraUsuario(createDto);
            if (resultado.IsFailed) return StatusCode(500);
            return Ok();
        }
    }
}
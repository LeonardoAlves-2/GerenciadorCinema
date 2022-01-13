using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Servico;
using GerenciadorDeCinema.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Api.Controllers
{
    [ApiController]
    [Route("login")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Login([FromBody] Usuario usuario)
        {
            var loginValido = await _usuarioService.Logar(usuario);

            if (loginValido)
                return Ok();

            return BadRequest("Email ou senha inválidos.");
        }
    }
}

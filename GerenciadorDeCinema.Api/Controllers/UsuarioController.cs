using GerenciadorDeCinema.Servico;
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
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        public IActionResult Login()
        {
            var tokenService = new TokenService();
            var token = tokenService.GenerateToken(null);

            return Ok(token);
        }
    }
}

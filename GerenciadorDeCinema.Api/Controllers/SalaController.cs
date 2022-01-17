using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Api.Controllers
{
    [ApiController]
    [Route("sala")]
    public class SalaController : Controller
    {
        private readonly ISalaService _salaService;

        public SalaController(ISalaService salaService)
        {
            _salaService = salaService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("")]
        public IActionResult Listar()
        {
            try
            {
                var salas = _salaService.ListarSalas();

                return Ok(salas);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
    }
}

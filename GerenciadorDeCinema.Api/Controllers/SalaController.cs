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
        [Route("listar")]
        public IActionResult Listar()
        {
            try
            {
                var salas = _salaService.ListarSalas();

                return Ok(salas);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("adicionar")]
        public IActionResult Adicionar([FromBody] Sala sala)
        {
            try
            {
                _salaService.Adicionar(sala);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete]
        [Route("deletar/{id}")]
        public IActionResult Remover([FromRoute] Guid id)
        {
            try
            {
                var sala = new Sala { Id = id };

                _salaService.Remover(sala);

                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

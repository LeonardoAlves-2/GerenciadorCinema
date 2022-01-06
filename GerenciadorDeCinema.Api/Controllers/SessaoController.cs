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
    [Route("sessao")]
    public class SessaoController : Controller
    {
        private readonly ISessaoService _sessaoService;

        public SessaoController(ISessaoService sessaoService)
        {
            _sessaoService = sessaoService;
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
                var sessoes = _sessaoService.ListarSessoes();

                return Ok(sessoes);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("adicionar")]
        public IActionResult Adicionar([FromBody] Sessao sessao)
        {
            try
            {
                _sessaoService.Adicionar(sessao);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut]
        [Route("editar/{id}")]
        public IActionResult Editar([FromBody] Sessao filmeEditado, [FromRoute] Guid id)
        {
            try
            {
                var sessao = new Sessao { Id = id };
                sessao = filmeEditado;

                _sessaoService.Editar(sessao);
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
                var sessao = new Sessao { Id = id };

                _sessaoService.Remover(sessao);

                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

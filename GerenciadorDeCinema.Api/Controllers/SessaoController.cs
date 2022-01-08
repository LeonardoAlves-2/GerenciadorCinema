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
        private readonly IFilmeService _filmeService;

        public SessaoController(ISessaoService sessaoService, IFilmeService filmeService)
        {
            _sessaoService = sessaoService;
            _filmeService = filmeService;
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
                var filme = _filmeService.ListarPeloId(sessao.FilmeSessao);
                var duracao = filme.DuracaoEmMinutos;

                sessao.FinalSessao = sessao.CalcularFinalSessao(duracao);

                if (ModelState.IsValid)
                {
                    _sessaoService.Adicionar(sessao);
                        return Ok();
                }

                throw new Exception();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut]
        [Route("editar/{id}")]
        public IActionResult Editar([FromBody] Sessao sessaoEditada, [FromRoute] Guid id)
        {
            try
            {
                var sessao = _sessaoService.ListarPeloId(id);
                sessao = sessaoEditada;

                var filme = _filmeService.ListarPeloId(sessao.FilmeSessao);
                var duracao = filme.DuracaoEmMinutos;

                sessao.FinalSessao = sessao.CalcularFinalSessao(duracao);

                if (ModelState.IsValid)
                {
                    _sessaoService.Editar(sessao);
                    return Ok();
                }

                throw new Exception();
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
                var sessao = _sessaoService.ListarPeloId(id);

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

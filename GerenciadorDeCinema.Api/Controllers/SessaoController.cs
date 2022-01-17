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
        private readonly ISessaoValidator _sessaoValidator;
        private readonly IFilmeService _filmeService;

        public SessaoController(ISessaoService sessaoService, ISessaoValidator sessaoValidator, IFilmeService filmeService)
        {
            _sessaoService = sessaoService;
            _sessaoValidator = sessaoValidator;
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

                return BadRequest();
            }
        }

        [HttpPost]
        [Route("adicionar")]
        public async Task<IActionResult> Adicionar([FromBody] Sessao sessao)
        {
            try
            {
                var filme = await _filmeService.ObterPeloId(sessao.FilmeId);
                var duracao = filme.Duracao;

                sessao.Final = sessao.CalcularFinalSessao(duracao);

                var resultValidation = _sessaoValidator.ValidarSessao(sessao);

                if (string.IsNullOrWhiteSpace(resultValidation))
                {
                    await _sessaoService.Adicionar(sessao);
                    return Ok();
                }

                return BadRequest(resultValidation);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpDelete]
        [Route("deletar/{id}")]
        public async Task<IActionResult> Remover([FromRoute] Guid id)
        {
            try
            {
                var sessao = await _sessaoService.ObterPeloId(id);

                if(sessao.Inicio>DateTime.UtcNow.AddDays(10))
                {
                    await _sessaoService.Remover(sessao);
                    return Ok();
                }
                return BadRequest("A sessão não pode ser deletada, faltam menos de 10 dias para ela ocorrer.");
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
    }
}

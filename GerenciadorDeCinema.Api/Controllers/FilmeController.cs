using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Api.Controllers
{
    [ApiController]
    [Route("filme")]
    public class FilmeController : Controller
    {
        private readonly IFilmeService _filmeService;
        private readonly IFilmeValidator _filmeValidator;

        public FilmeController(IFilmeService filmeService, IFilmeValidator filmeValidator)
        {
            _filmeService = filmeService;
            _filmeValidator = filmeValidator;
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
                var filmes = _filmeService.ListarFilmes();

                return Ok(filmes);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("adicionar")]
        public async Task<IActionResult> Adicionar([FromBody] Filme filme)
        {
            try
            {
                var resultValidation = _filmeValidator.ValidarFilme(filme);

                if (string.IsNullOrWhiteSpace(resultValidation))
                {
                    await _filmeService.Adicionar(filme);
                    return Ok(filme);
                }

                return BadRequest(resultValidation);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("editar/{id}")]
        public async Task<IActionResult> Editar([FromBody] Filme filmeEditado, [FromRoute] Guid id)
        {
            try
            {
                var filme = new Filme { Id = id };
                filme = filmeEditado;
                filme.Id = id;

                var resultValidation = _filmeValidator.ValidarFilme(filme);

                if(string.IsNullOrWhiteSpace(resultValidation))
                {
                    await _filmeService.Editar(filme);
                    return Ok();
                }

                return BadRequest(resultValidation);

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("deletar/{id}")]
        public async Task<IActionResult> Remover([FromRoute]Guid id)
        {
            try
            {
                var filme = new Filme { Id = id };
                
                await _filmeService.Remover(filme);

                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}

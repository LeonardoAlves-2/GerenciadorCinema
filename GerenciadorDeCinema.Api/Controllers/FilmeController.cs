using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

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
        public IActionResult Adicionar([FromBody] Filme filme)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_filmeValidator.ValidarFilme(filme)))
                {
                    _filmeService.Adicionar(filme);
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
        public IActionResult Editar([FromBody] Filme filmeEditado, [FromRoute] Guid id)
        {
            try
            {
                var filme = new Filme { Id = id };
                filme = filmeEditado;
                filme.Id = id;



                if (ModelState.IsValid)
                {
                    _filmeService.Editar(filme);
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
        public IActionResult Remover([FromRoute]Guid id)
        {
            try
            {
                var filme = new Filme { Id = id };
                
                _filmeService.Remover(filme);

                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

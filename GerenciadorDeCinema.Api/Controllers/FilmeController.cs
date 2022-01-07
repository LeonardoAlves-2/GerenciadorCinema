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

        public FilmeController(IFilmeService filmeService)
        {
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
                if (ModelState.IsValid)
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

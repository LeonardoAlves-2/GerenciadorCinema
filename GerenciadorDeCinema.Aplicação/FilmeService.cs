using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using GerenciadorDeCinema.Servico.Interfaces;
using System.Collections.Generic;

namespace GerenciadorDeCinema.Servico
{
    public class FilmeService : IFilmeService
    {
        private readonly IFilmeRepositorio _filmeRepositorio;
        public FilmeService(IFilmeRepositorio filmeRepositorio)
        {
            _filmeRepositorio = filmeRepositorio;
        }

        public IEnumerable<Filme> ListarFilmes()
        {
            var filmes = _filmeRepositorio.Listar();
            return filmes;
        }

        public void Adicionar(Filme filme)
        {
            _filmeRepositorio.Adicionar(filme);
        }

        public void Editar(Filme filme)
        {
            _filmeRepositorio.Editar(filme);
        }

        public void Remover(Filme filme)
        {
            _filmeRepositorio.Remover(filme);
        }
    }
}

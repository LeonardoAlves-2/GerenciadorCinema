using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using GerenciadorDeCinema.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async Task Adicionar(Filme filme)
        {
            await _filmeRepositorio.Adicionar(filme);
        }

        public async Task Editar(Filme filme)
        {
            await _filmeRepositorio.Editar(filme);
        }

        public async Task Remover(Filme filme)
        {
            await _filmeRepositorio.Remover(filme);
        }

        public async Task<Filme> ListarPeloId(Guid itemId)
        {
            return await _filmeRepositorio.ListarPeloId(itemId);
        }

    }
}

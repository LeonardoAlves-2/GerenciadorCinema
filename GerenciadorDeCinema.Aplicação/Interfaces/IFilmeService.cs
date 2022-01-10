using GerenciadorDeCinema.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Servico.Interfaces
{
    public interface IFilmeService
    {
        public IEnumerable<Filme> ListarFilmes();
        public Task Adicionar(Filme filme);
        public Task Remover(Filme filme);
        public Task<Filme> ListarPeloId(Guid filmeId);
        public Task Editar(Filme filme);
    }
}

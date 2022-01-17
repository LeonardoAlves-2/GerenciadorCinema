using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using GerenciadorDeCinema.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Servico
{
    public class SessaoService : ISessaoService
    {
        private readonly ISessaoRepositorio _sessaoRepositorio;
        public SessaoService(ISessaoRepositorio sessaoRepositorio)
        {
            _sessaoRepositorio = sessaoRepositorio;
        }

        public IEnumerable<Sessao> ListarSessoes()
        {
            var filmes = _sessaoRepositorio.Listar();
            return filmes;
        }

        public async Task Adicionar(Sessao sessao)
        {
            await _sessaoRepositorio.Adicionar(sessao);
        }

        public async Task Remover(Sessao sessao)
        {
            await _sessaoRepositorio.Remover(sessao);
        }
        public async Task<Sessao> ObterPeloId(Guid itemId)
        {
            return await _sessaoRepositorio.ObterPeloId(itemId);
        }
    }
}

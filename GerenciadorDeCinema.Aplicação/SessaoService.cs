using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using GerenciadorDeCinema.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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

        public void Adicionar(Sessao sessao)
        {
            _sessaoRepositorio.Adicionar(sessao);
        }

        public void Editar(Sessao sessao)
        {
            _sessaoRepositorio.Editar(sessao);
        }

        public void Remover(Sessao sessao)
        {
            _sessaoRepositorio.Remover(sessao);
        }
        public Sessao ListarPeloId(Guid itemId)
        {   
            return _sessaoRepositorio.ListarPeloId(itemId);
        }
    }
}

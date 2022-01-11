using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Teste.Repositorios
{
    public class FakeSessaoRepositorio : ISessaoRepositorio
    {
        new Filme filme;
        IList<Sessao> sessoes = new List<Sessao>()
        {
            new Sessao(DateTime.UtcNow.AddDays(11), Filme.Id, DateTime.UtcNow.AddDays(11).AddHours(2),12)
        }

        public Task Adicionar(Sessao item)
        {
            throw new NotImplementedException();
        }

        public Task Editar(Sessao item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sessao> Listar()
        {
            throw new NotImplementedException();
        }

        public Task<Sessao> ListarPeloId(Guid itemId)
        {
            throw new NotImplementedException();
        }

        public Task Remover(Sessao item)
        {
            throw new NotImplementedException();
        }
    }
}

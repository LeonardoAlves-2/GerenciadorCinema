using GerenciadorDeCinema.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Servico.Interfaces
{
    public interface ISessaoService 
    {
        public IEnumerable<Sessao> ListarSessoes();
        public Task Adicionar(Sessao sessao);
        public Task Remover(Sessao sessao);
        public Task<Sessao> ListarPeloId(Guid sessaoId);
        public Task Editar(Sessao sessao);
    }
}

using GerenciadorDeCinema.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCinema.Servico.Interfaces
{
    public interface ISessaoService 
    {
        public IEnumerable<Sessao> ListarSessoes();
        public void Adicionar(Sessao sessao);
        public void Remover(Sessao sessao);
        public void Editar(Sessao sessao);
    }
}

using GerenciadorDeCinema.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace GerenciadorDeCinema.Servico.Interfaces
{
    public interface IFilmeService
    {
        public IEnumerable<Filme> ListarFilmes();
        public void Adicionar(Filme filme);
        public void Remover(Filme filme);
        public void Editar(Filme filme);
    }
}

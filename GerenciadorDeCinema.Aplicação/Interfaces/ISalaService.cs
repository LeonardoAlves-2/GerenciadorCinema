using GerenciadorDeCinema.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCinema.Servico.Interfaces
{
    public interface ISalaService
    {
        public IEnumerable<Sala> ListarSalas();
        public void Adicionar(Sala sala);
        public void Remover(Sala sala);
        public void Editar(Sala sala);
    }
}

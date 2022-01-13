using GerenciadorDeCinema.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Servico.Interfaces
{
    public interface ISalaService
    {
        public IEnumerable<Sala> ListarSalas();
    }
}

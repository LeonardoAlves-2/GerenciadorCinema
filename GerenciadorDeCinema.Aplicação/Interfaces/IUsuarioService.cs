using GerenciadorDeCinema.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Servico.Interfaces
{
    public interface IUsuarioService
    {
        public Task<bool> Logar(Usuario usuario);
    }
}

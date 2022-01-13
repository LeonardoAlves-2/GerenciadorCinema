using GerenciadorDeCinema.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<Usuario> ListarPeloId(Guid itemId);

        //Task<> Logar(string email, string senha);
    }
}

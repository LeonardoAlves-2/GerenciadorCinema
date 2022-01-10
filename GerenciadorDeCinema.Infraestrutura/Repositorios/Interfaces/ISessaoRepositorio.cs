using GerenciadorDeCinema.Dominio.Entidades;
using System;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces
{
    public interface ISessaoRepositorio : IRepositorioBase<Sessao>
    {
        Task<Sessao> ListarPeloId(Guid itemId);
    }
}
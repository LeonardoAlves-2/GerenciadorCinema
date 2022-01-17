using GerenciadorDeCinema.Dominio.Entidades;
using System;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces
{
    public interface IFilmeRepositorio : IRepositorioBase<Filme>
    {
        Task<Filme> ObterPeloId(Guid itemId);

    }
}
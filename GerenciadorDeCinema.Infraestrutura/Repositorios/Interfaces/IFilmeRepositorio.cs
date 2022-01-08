using GerenciadorDeCinema.Dominio.Entidades;
using System;

namespace GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces
{
    public interface IFilmeRepositorio : IRepositorioBase<Filme>
    {
        Filme ListarPeloId(Guid itemId);

    }
}
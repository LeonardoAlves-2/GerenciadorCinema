using GerenciadorDeCinema.Dominio.Entidades;
using System;

namespace GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces
{
    public interface ISessaoRepositorio : IRepositorioBase<Sessao>
    {
        Sessao   ListarPeloId(Guid itemId);
    }
}
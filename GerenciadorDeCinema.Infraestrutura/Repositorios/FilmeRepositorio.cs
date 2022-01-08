using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace GerenciadorDeCinema.Infraestrutura.Repositorios
{
    public class FilmeRepositorio : RepositorioBase<Filme>, IFilmeRepositorio
    {
        public FilmeRepositorio(DbContext context)
            : base(context)
        { }

        public virtual Filme ListarPeloId(Guid itemId)
        {
            Filme itemFilme = _context.Set<Filme>().SingleOrDefault(e => e.Id == itemId);
            return itemFilme;
        }
    }
}

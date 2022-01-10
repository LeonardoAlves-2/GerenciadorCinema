using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Infraestrutura.Repositorios
{
    public class FilmeRepositorio : RepositorioBase<Filme>, IFilmeRepositorio
    {
        public FilmeRepositorio(DbContext context)
            : base(context)
        { }

        public async virtual Task<Filme> ListarPeloId(Guid itemId)
        {
            Filme itemFilme = await _context.Set<Filme>().SingleOrDefaultAsync(e => e.Id == itemId);
            return itemFilme;
        }
    }
}

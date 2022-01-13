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

        public async virtual Task<Filme> ObterPeloId(Guid itemId)
        {
            Filme itemFilme = await _context.Set<Filme>().FirstOrDefaultAsync(e => e.Id == itemId);
            return itemFilme;
        }
    }
}

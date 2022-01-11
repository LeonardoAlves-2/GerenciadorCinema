using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCinema.Infraestrutura.Repositorios
{
    public class SessaoRepositorio : RepositorioBase<Sessao>, ISessaoRepositorio
    {
        public SessaoRepositorio(DbContext context)
            : base(context)
        { }

        public async virtual Task<Sessao> ListarPeloId(Guid itemId)
        {
            Sessao itemSessao = await _context.Set<Sessao>().FirstOrDefaultAsync(e => e.Id == itemId);
            return itemSessao;
        }
    }
}

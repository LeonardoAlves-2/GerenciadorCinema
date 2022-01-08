using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorDeCinema.Infraestrutura.Repositorios
{
    public class SessaoRepositorio : RepositorioBase<Sessao>, ISessaoRepositorio
    {
        public SessaoRepositorio(DbContext context)
            : base(context)
        { }

        public virtual Sessao ListarPeloId(Guid itemId)
        {
            Sessao itemSessao = _context.Set<Sessao>().SingleOrDefault(e => e.Id == itemId);
            return itemSessao;
        }
    }
}

using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCinema.Infraestrutura.Repositorios
{
    public class SessaoRepositorio : RepositorioBase<Sessao>, ISessaoRepositorio
    {
        public SessaoRepositorio(DbContext context)
            : base(context)
        { }
    }
}

using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeCinema.Infraestrutura.Repositorios
{
    public class FilmeRepositorio : RepositorioBase<Filme>, IFilmeRepositorio
    {
        public FilmeRepositorio(DbContext context)
            : base(context)
        { }
    }
}

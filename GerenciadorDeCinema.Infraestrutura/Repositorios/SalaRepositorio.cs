using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeCinema.Infraestrutura.Repositorios
{
    public class SalaRepositorio : RepositorioBase<Sala>, ISalaRepositorio
    {
        public SalaRepositorio(DbContext context)
            : base(context)
        { }
    }
}

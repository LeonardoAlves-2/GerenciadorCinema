using GerenciadorDeCinema.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeCinema.Infraestrutura
{
    public class CinemaContext : DbContext
    {
        public CinemaContext(DbContextOptions<CinemaContext> options)
        : base(options)
        { }

        public DbSet<Filme> Filme { get; set; }
        public DbSet<Sessao> Sessao { get; set; }
        public DbSet<Sala> Sala { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS02;Database=GerenciadorDeCinema;Trusted_Connection=True;");
        }

    }
}

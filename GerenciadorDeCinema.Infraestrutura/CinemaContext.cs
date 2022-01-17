using GerenciadorDeCinema.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;

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
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            mb.Entity<Sala>().HasData(
                new Sala() { Id = Guid.NewGuid(), Nome = "Sala 1", QuantidadeDeAssentos = 40},
                new Sala() { Id = Guid.NewGuid(), Nome = "Sala 2", QuantidadeDeAssentos = 50 },
                new Sala() { Id = Guid.NewGuid(), Nome = "Sala 3", QuantidadeDeAssentos = 60 }
            );
            mb.Entity<Usuario>().HasData(
                new Usuario() { Id = Guid.NewGuid(), Email = "admin@cinema.com", Senha = "admin43" });
        }
    }
}

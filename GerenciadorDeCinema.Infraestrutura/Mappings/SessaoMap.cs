using GerenciadorDeCinema.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCinema.Infraestrutura.Mappings
{
    public class SessaoMap : Map<Sessao>
    {
        public override void Configure(EntityTypeBuilder<Sessao> builder)
        {
            base.Configure(builder);
            builder.ToTable("Sessao");

            builder.HasKey(c => c.InicioSessao);

            builder.Property(c => c.InicioSessao).IsRequired().HasColumnName("Inicio-Sessao");
            builder.Property(c => c.FilmeSessao).IsRequired().HasColumnName("Filme-Sessao");
            builder.Property(c => c.FilmeSessao).IsRequired().HasColumnName("Final-Sessao");
            builder.Property(c => c.SalaSessao).IsRequired().HasColumnName("Sala-Sessao");
        }
    }
}

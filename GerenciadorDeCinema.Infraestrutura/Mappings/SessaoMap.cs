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

            builder.HasKey(c => c.Inicio);

            builder.Property(c => c.Inicio).IsRequired().HasColumnName("InicioSessao");
            builder.Property(c => c.FilmeId).IsRequired().HasColumnName("FilmeSessao");
            builder.Property(c => c.FilmeId).IsRequired().HasColumnName("FinalSessao");
            builder.Property(c => c.SalaId).IsRequired().HasColumnName("SalaSessao");
            builder.Property(c => c.ValorIngresso).IsRequired().HasColumnName("ValorIngresso");
        }
    }
}

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

            builder.Property(c => c.Inicio).IsRequired().HasColumnName("Inicio");
            builder.Property(c => c.Final).IsRequired().HasColumnName("Final");
            builder.Property(c => c.FilmeId).IsRequired().HasColumnName("FilmeId");
            builder.Property(c => c.SalaId).IsRequired().HasColumnName("SalaId");
            builder.Property(c => c.Animacao).IsRequired().HasColumnName("Animacao");
            builder.Property(c => c.Audio).IsRequired().HasColumnName("Audio");
            builder.Property(c => c.ValorIngresso).IsRequired().HasColumnType("decimal(01,5)").HasColumnName("ValorIngresso");
        }
    }
}

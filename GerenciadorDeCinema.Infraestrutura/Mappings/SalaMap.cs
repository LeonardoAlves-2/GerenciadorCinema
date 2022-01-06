using GerenciadorDeCinema.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCinema.Infraestrutura.Mappings
{
    public class SalaMap : Map<Sala>
    {
        public override void Configure(EntityTypeBuilder<Sala> builder)
        {
            base.Configure(builder);
            builder.ToTable("Sala");

            builder.HasKey(c => c.Nome);

            builder.Property(c => c.Nome).IsRequired().HasColumnName("Nome");
            builder.Property(c => c.QuantidadeMaxima).IsRequired().HasColumnName("Quantidade-Maxima");
            builder.Property(c => c.Sessoes).IsRequired().HasColumnName("Sessoes");
        }
    }
}

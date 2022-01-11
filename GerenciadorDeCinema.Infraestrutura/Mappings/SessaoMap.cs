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

            builder.Property(c => c.Inicio).IsRequired().HasColumnName("Inicio-Sessao");
            builder.Property(c => c.Filme).IsRequired().HasColumnName("Filme-Sessao");
            builder.Property(c => c.Filme).IsRequired().HasColumnName("Final-Sessao");
            builder.Property(c => c.Sala).IsRequired().HasColumnName("Sala-Sessao");
        }
    }
}

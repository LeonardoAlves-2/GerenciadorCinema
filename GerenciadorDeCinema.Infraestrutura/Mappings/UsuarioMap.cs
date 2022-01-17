using GerenciadorDeCinema.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCinema.Infraestrutura.Mappings
{
    public class UsuarioMap : Map<Usuario>
    {
        public override void Configure(EntityTypeBuilder<Usuario> builder)
        {
            base.Configure(builder);
            builder.ToTable("Usuario");

            builder.HasKey(c => c.Email);

            builder.Property(c => c.Email).IsRequired().HasColumnName("Email");
            builder.Property(c => c.Senha).IsRequired().HasColumnName("Senha");
        }
    }
}

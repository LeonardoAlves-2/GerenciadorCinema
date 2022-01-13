using GerenciadorDeCinema.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeCinema.Infraestrutura.Mappings
{
    public class FilmeMap : Map<Filme>
    {
        public override void Configure(EntityTypeBuilder<Filme> builder)
        {
            base.Configure(builder);
            builder.ToTable("Filme");

            builder.HasKey(c => c.Titulo);

            builder.Property(c => c.Titulo).IsRequired().HasColumnName("Titulo").HasMaxLength(100);
            builder.Property(c => c.Duracao).IsRequired().HasColumnName("Duracao");
            builder.Property(c => c.Descricao).IsRequired().HasColumnName("Descricao");
        }
    }
}
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
            builder.Property(c => c.Categoria).IsRequired().HasColumnName("Categoria");
            builder.Property(c => c.Classificacao_Indicativa).IsRequired().HasDefaultValue(0).HasColumnName("Classificacao_Indicativa");
            builder.Property(c => c.DuracaoEmMinutos).IsRequired().HasColumnName("Duracao");
            builder.Property(c => c.Sinopse).IsRequired().HasColumnName("Sinopse");
            builder.Property(c => c.Animacao).IsRequired().HasColumnName("Animacao");
            builder.Property(c => c.Audio).IsRequired().HasColumnName("Audio");
        }
    }
}
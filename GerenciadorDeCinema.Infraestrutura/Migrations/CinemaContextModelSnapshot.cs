﻿// <auto-generated />
using System;
using GerenciadorDeCinema.Infraestrutura;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GerenciadorDeCinema.Infraestrutura.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GerenciadorDeCinema.Dominio.Entidades.Filme", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Animacao")
                        .HasColumnType("int");

                    b.Property<int>("Audio")
                        .HasColumnType("int");

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<int>("Classificacao_Indicativa")
                        .HasColumnType("int");

                    b.Property<int>("DuracaoEmMinutos")
                        .HasColumnType("int");

                    b.Property<string>("Sinopse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Filme");
                });

            modelBuilder.Entity("GerenciadorDeCinema.Dominio.Entidades.Sala", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantidadeMaxima")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sala");
                });

            modelBuilder.Entity("GerenciadorDeCinema.Dominio.Entidades.Sessao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FilmeSessao")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FinalSessao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InicioSessao")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("SalaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SalaSessao")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SalaId");

                    b.ToTable("Sessao");
                });

            modelBuilder.Entity("GerenciadorDeCinema.Dominio.Entidades.Sessao", b =>
                {
                    b.HasOne("GerenciadorDeCinema.Dominio.Entidades.Sala", null)
                        .WithMany("Sessoes")
                        .HasForeignKey("SalaId");
                });
#pragma warning restore 612, 618
        }
    }
}

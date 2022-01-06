using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciadorDeCinema.Infraestrutura.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Filme",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    Categoria = table.Column<int>(nullable: false),
                    Classificacao_Indicativa = table.Column<int>(nullable: false),
                    Duracao = table.Column<DateTime>(nullable: false),
                    Sinopse = table.Column<string>(nullable: true),
                    Animacao = table.Column<int>(nullable: false),
                    Audio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filme", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sala",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    QuantidadeMaxima = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sala", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sessao",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    InicioSessao = table.Column<DateTime>(nullable: false),
                    FilmeSessaoId = table.Column<Guid>(nullable: true),
                    FinalSessao = table.Column<DateTime>(nullable: false),
                    SalaSessaoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessao_Filme_FilmeSessaoId",
                        column: x => x.FilmeSessaoId,
                        principalTable: "Filme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Sessao_Sala_SalaSessaoId",
                        column: x => x.SalaSessaoId,
                        principalTable: "Sala",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sessao_FilmeSessaoId",
                table: "Sessao",
                column: "FilmeSessaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessao_SalaSessaoId",
                table: "Sessao",
                column: "SalaSessaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sessao");

            migrationBuilder.DropTable(
                name: "Filme");

            migrationBuilder.DropTable(
                name: "Sala");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciadorDeCinema.Infraestrutura.Migrations
{
    public partial class MinhaMigration : Migration
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
                    ClassificacaoIndicativa = table.Column<int>(nullable: false),
                    Duracao = table.Column<int>(nullable: false),
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
                    Inicio = table.Column<DateTime>(nullable: false),
                    Filme = table.Column<Guid>(nullable: false),
                    Final = table.Column<DateTime>(nullable: false),
                    Sala = table.Column<Guid>(nullable: false),
                    SalaId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessao_Sala_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Sala",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sessao_SalaId",
                table: "Sessao",
                column: "SalaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filme");

            migrationBuilder.DropTable(
                name: "Sessao");

            migrationBuilder.DropTable(
                name: "Sala");
        }
    }
}

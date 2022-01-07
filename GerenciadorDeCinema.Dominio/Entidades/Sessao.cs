using System;

namespace GerenciadorDeCinema.Dominio.Entidades
{
    public class Sessao : EntidadeBase
    {
        public DateTime InicioSessao { get; set; }
        public string FilmeSessao { get; set; }
        public DateTime FinalSessao { get; set; }
        public string SalaSessao { get; set; }

        public DateTime CalcularFinalSessao(string filmeSessaoTitulo)
        {
            var filmeSessao = new Filme { Titulo = filmeSessaoTitulo};


            var finalSessao = InicioSessao.AddHours(filmeSessao.Duracao.Hour).AddMinutes(filmeSessao.Duracao.Minute).AddSeconds(filmeSessao.Duracao.Second);
            return finalSessao;
        }
    }
}
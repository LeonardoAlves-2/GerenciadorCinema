using System;

namespace GerenciadorDeCinema.Dominio.Entidades
{
    public class Sessao : EntidadeBase
    {
        public DateTime InicioSessao { get; set; }
        public Filme FilmeSessao { get; set; }
        public DateTime FinalSessao { get; set; }
        public Sala SalaSessao { get; set; }
    }
}
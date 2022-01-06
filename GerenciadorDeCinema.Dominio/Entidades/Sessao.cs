using System;

namespace GerenciadorDeCinema.Dominio.Entidades
{
    public class Sessao : EntidadeBase
    {
        public DateTime InicioSessao { get; private set; }
        public Filme FilmeSessao { get; private set; }
        public DateTime FinalSessao { get; private set; }
        public Sala SalaSessao { get; private set; }
    }
}
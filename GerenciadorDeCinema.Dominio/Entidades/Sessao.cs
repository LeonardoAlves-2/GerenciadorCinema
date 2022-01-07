using System;

namespace GerenciadorDeCinema.Dominio.Entidades
{
    public class Sessao : EntidadeBase
    {
        public DateTime InicioSessao { get; set; }
        public Guid FilmeSessao { get; set; }
        public DateTime FinalSessao { get; set; }
        public Guid SalaSessao { get; set; }

        public DateTime CalcularFinalSessao(TimeSpan filmeSessaoDuracao)
        {
            var finalSessao = InicioSessao.Add(filmeSessaoDuracao);
            return finalSessao;
        }
    }
}
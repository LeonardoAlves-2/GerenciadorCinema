using System;

namespace GerenciadorDeCinema.Dominio.Entidades
{
    public class Sessao : EntidadeBase
    {
        public DateTime InicioSessao { get; set; }
        public Guid FilmeSessao { get; set; }
        public DateTime FinalSessao { get; set; }
        public Guid SalaSessao { get; set; }

        public DateTime CalcularFinalSessao(int filmeSessaoDuracao)
        {
            var finalSessao = InicioSessao.AddMinutes(filmeSessaoDuracao);
            return finalSessao;
        }
    }
}
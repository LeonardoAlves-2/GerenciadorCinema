using System;

namespace GerenciadorDeCinema.Dominio.Entidades
{
    public class Sessao : EntidadeBase
    {
        public DateTime Inicio { get; set; }
        public Guid Filme { get; set; }
        public DateTime Final { get; set; }
        public Guid Sala { get; set; }

        public DateTime CalcularFinalSessao(int filmeSessaoDuracao)
        {
            var finalSessao = Inicio.AddMinutes(filmeSessaoDuracao);
            return finalSessao;
        }
    }
}
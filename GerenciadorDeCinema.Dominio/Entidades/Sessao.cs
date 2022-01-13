using GerenciadorDeCinema.Dominio.Enums;
using System;

namespace GerenciadorDeCinema.Dominio.Entidades
{
    public class Sessao : EntidadeBase
    {
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }
        public Guid FilmeId { get; set; }
        public virtual Filme Filme { get; set; }
        public Guid SalaId { get; set; }
        public virtual Sala Sala { get; set; }
        public EAnimacao Animacao { get; set; }
        public EAudio Audio { get; set; }
        public decimal ValorIngresso { get; set; }

        public DateTime CalcularFinalSessao(int duracao)
            => Inicio.AddMinutes(duracao);
    }
}
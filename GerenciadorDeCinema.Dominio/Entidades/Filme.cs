using GerenciadorDeCinema.Dominio.Enums;
using System;

namespace GerenciadorDeCinema.Dominio.Entidades
{
    public class Filme : EntidadeBase
    {
        public string Titulo { get; set; }
        public ECategoria Categoria { get; set; }
        public EClassificacaoIndicativa Classificacao_Indicativa { get;  set; }
        public DateTime Duracao { get; set; }
        public string Sinopse { get; set; }
        public EAnimacao Animacao { get; set; }
        public EAudio Audio { get; set; }

        public DateTime CalcularFinalSessão(DateTime dataSessao)
        {
            var finalSessão = dataSessao.AddHours(Duracao.Hour).AddMinutes(Duracao.Minute);
            return finalSessão;
        }
    }
}
using GerenciadorDeCinema.Dominio.Enums;
using System;

namespace GerenciadorDeCinema.Dominio.Entidades
{
    public class Filme : EntidadeBase
    {
        public string Titulo { get; set; }
        public ECategoria Categoria { get; set; }
        public EClassificacaoIndicativa ClassificacaoIndicativa { get;  set; }
        public int Duracao { get; set; }
        public string Sinopse { get; set; }
        public EAnimacao Animacao { get; set; }
        public EAudio Audio { get; set; }
    }
}
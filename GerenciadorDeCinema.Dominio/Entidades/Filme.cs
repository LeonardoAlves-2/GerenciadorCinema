using System;

namespace GerenciadorDeCinema.Dominio.Entidades
{
    public class Filme : EntidadeBase
    {
        public string Imagem { get; set; }
        public string Titulo { get; set; }
        public int Duracao { get; set; }
        public string Descricao { get; set; }
    }
}
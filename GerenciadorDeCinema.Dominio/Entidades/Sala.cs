using GerenciadorDeCinema.Dominio.Entidades;
using System.Collections.Generic;

namespace GerenciadorDeCinema.Dominio.Entidades
{
    public class Sala : EntidadeBase
    {
        public string Nome { get; set; }
        public int QuantidadeMaxima { get; set; }
    }
}
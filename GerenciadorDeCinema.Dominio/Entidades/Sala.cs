using GerenciadorDeCinema.Dominio.Entidades;
using System.Collections.Generic;

namespace GerenciadorDeCinema.Dominio.Entidades
{
    public class Sala : EntidadeBase
    {
        public string Nome { get; private set; }
        public int QuantidadeMaxima { get; private set; }
        public IList<Sessao> Sessoes { get; private set; }
    }
}
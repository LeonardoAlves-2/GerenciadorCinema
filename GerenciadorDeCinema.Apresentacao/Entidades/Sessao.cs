using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Apresentacao.Entidades
{
    public class Sessao
    {
        public Guid Id { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }
        public Guid FilmeId { get; set; }
        public virtual Filme Filme { get; set; }
        public Guid SalaId { get; set; }
        public virtual Sala Sala { get; set; }
        public int Animacao { get; set; }
        public int Audio { get; set; }
        public decimal ValorIngresso { get; set; }
    }
}

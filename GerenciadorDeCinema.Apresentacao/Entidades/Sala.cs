using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Apresentacao.Entidades
{
    public class Sala
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeDeAssentos { get; set; }
    }
}

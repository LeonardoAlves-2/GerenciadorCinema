using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Apresentacao.Entidades
{
    public class Filme
    {
        public Guid Id { get; set; }
        public byte[] Imagem { get; set; }
        public string Titulo { get; set; }
        public int Duracao { get; set; }
        public string Descricao { get; set; }
    }
}

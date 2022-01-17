using GerenciadorDeCinema.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCinema.TesteDeUnidade.Builders
{
    public class FilmeBuilder
    {
        public Filme filme = new Filme { 
            Id = Guid.NewGuid(), Titulo = "Titulo", Descricao = "Isto é um teste", Duracao = 120 };
    }
}

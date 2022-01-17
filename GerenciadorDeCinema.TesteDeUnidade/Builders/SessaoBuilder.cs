using GerenciadorDeCinema.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCinema.TesteDeUnidade.Builders
{
    public class SessaoBuilder
    {
        public Sessao sessao = new Sessao
        {
            Id = Guid.NewGuid(),
            Inicio = DateTime.UtcNow.AddDays(11),
            FilmeId = new FilmeBuilder().filme.Id,
            SalaId = Guid.NewGuid(),
            Animacao = (Dominio.Enums.EAnimacao)2,
            Audio = (Dominio.Enums.EAudio)1,
            ValorIngresso = (decimal)7.50
        };
    }
}

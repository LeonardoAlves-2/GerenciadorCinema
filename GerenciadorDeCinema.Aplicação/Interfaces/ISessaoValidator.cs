using GerenciadorDeCinema.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCinema.Servico.Interfaces
{
    public interface ISessaoValidator
    {
        string ValidarSessao(Sessao sessao);
    }
}

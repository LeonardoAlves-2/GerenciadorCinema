using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;

namespace GerenciadorDeCinema.Servico
{
    public class SessaoValidator : ISessaoValidator
    {
        private readonly ISessaoRepositorio _sessaoRepositorio;

        public SessaoValidator(ISessaoRepositorio sessaoRepositorio)
        {
            _sessaoRepositorio = sessaoRepositorio;
        }

        public string ValidarSessao(Sessao sessao)
        {
            var sessaoValidator = new Validators.SessaoValidator(_sessaoRepositorio);

            var resultValidation = sessaoValidator.Validate(sessao);

            if (resultValidation.Errors.Any())
            {
                return String.Join("\n", resultValidation.Errors);
            }

            return string.Empty;

        }
    }
}

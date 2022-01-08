using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GerenciadorDeCinema.Servico
{
    public class FilmeValidator : IFilmeValidator
    {
        public string ValidarFilme(Filme filme)
        {

            var filmeValidator = new Validators.FilmeValidator();

            var resultValidation = filmeValidator.Validate(filme);

            if (resultValidation.Errors.Any())
            {
                return String.Join("", resultValidation.Errors);
            }

            return string.Empty;

        }
    }
}

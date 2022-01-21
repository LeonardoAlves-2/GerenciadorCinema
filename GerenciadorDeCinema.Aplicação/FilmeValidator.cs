using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;

namespace GerenciadorDeCinema.Servico
{
    public class FilmeValidator : IFilmeValidator
    {
        private readonly IFilmeRepositorio _filmeRepositorio;

        public FilmeValidator(IFilmeRepositorio filmeRepositorio)
        {
            _filmeRepositorio = filmeRepositorio;
        }

        public string ValidarFilme(Filme filme)
        {
            var filmeValidator = new Validators.FilmeValidator(_filmeRepositorio);

            var resultValidation = filmeValidator.Validate(filme);

            if (resultValidation.Errors.Any())
            {
                return String.Join("\n", resultValidation.Errors);
            }

            return string.Empty;

        }
    }
}

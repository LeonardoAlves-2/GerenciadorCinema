using FluentAssertions;
using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Servico;
using GerenciadorDeCinema.Servico.Interfaces;
using GerenciadorDeCinema.TesteDeUnidade.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GerenciadorDeCinema.TesteDeUnidade.Validators
{
    public class FilmeValidatorTest
    {
        private readonly IFilmeValidator _filmeValidator;
        public FilmeValidatorTest(IFilmeValidator filmeValidator)
        {
            _filmeValidator = filmeValidator;
        }

        [Fact]
        public void Deve_retornar_true_quando_filme_for_valido()
        {
            //Arrange
            Filme f = new FilmeBuilder().filme;
            //Act
            var resultValidation = _filmeValidator.ValidarFilme(f);

            //Assert
            resultValidation.Should().BeNull();
        }
    }
}

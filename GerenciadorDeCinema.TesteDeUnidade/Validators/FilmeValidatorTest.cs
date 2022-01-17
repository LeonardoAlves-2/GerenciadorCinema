using FluentAssertions;
using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using GerenciadorDeCinema.Servico;
using GerenciadorDeCinema.Servico.Interfaces;
using GerenciadorDeCinema.TesteDeUnidade.Builders;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GerenciadorDeCinema.TesteDeUnidade.Validators
{
    public class FilmeValidatorTest
    {
        [Fact]
        public void Deve_retornar_vazio_quando_filme_for_valido()
        {
            //Arrange
            Filme f = new FilmeBuilder().filme;

            var mockRepo = new Mock<IFilmeRepositorio>();
            var validator = new FilmeValidator(mockRepo.Object);

            //Act
            var resultValidation = validator.ValidarFilme(f);

            //Assert
            resultValidation.Should().Be(string.Empty);
        }

        [Fact]
        public void Deve_retornar_com_valor_quando_titulo_for_vazio()
        {
            //Arrange
            Filme f = new FilmeBuilder().filme;
            f.Titulo = "";

            var mockRepo = new Mock<IFilmeRepositorio>();
            var validator = new FilmeValidator(mockRepo.Object);

            //Act
            var resultValidation = validator.ValidarFilme(f);

            //Assert
            resultValidation.Should().Be("Campo requirido.");
        }

        [Fact]
        public void Deve_retornar_com_valor_quando_imagem_for_vazia()
        {
            //Arrange
            Filme f = new FilmeBuilder().filme;
            f.Imagem = new byte[] { };

            var mockRepo = new Mock<IFilmeRepositorio>();
            var validator = new FilmeValidator(mockRepo.Object);

            //Act
            var resultValidation = validator.ValidarFilme(f);

            //Assert
            resultValidation.Should().Be("Campo requirido.");
        }

        [Fact]
        public void Deve_retornar_com_valor_quando_duracao_for_menor_que_zero()
        {
            //Arrange
            Filme f = new FilmeBuilder().filme;
            f.Duracao = -1;

            var mockRepo = new Mock<IFilmeRepositorio>();
            var validator = new FilmeValidator(mockRepo.Object);

            //Act
            var resultValidation = validator.ValidarFilme(f);

            //Assert
            resultValidation.Should().Be("A Duracao precisa ser maior que zero.");
        }

        [Fact]
        public void Deve_retornar_com_valor_quando_duracao_for_vazia()
        {
            //Arrange
            Filme f = new Filme
            {
                Id = Guid.NewGuid(),
                Imagem = new byte[] { 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20 },
                Titulo = "Titulo",
                Descricao = "Isto é um teste"
            };

            var mockRepo = new Mock<IFilmeRepositorio>();
            var validator = new FilmeValidator(mockRepo.Object);

            //Act
            var resultValidation = validator.ValidarFilme(f);

            //Assert
            resultValidation.Should().Be("Campo requirido.");
        }

        [Fact]
        public void Deve_retornar_com_valor_quando_descricao_for_vazia()
        {
            //Arrange
            Filme f = new FilmeBuilder().filme;
            f.Descricao = "";

            var mockRepo = new Mock<IFilmeRepositorio>();
            var validator = new FilmeValidator(mockRepo.Object);

            //Act
            var resultValidation = validator.ValidarFilme(f);

            //Assert
            resultValidation.Should().Be("Campo requirido.");
        }
    }
}

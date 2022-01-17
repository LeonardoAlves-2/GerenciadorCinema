using FluentAssertions;
using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using GerenciadorDeCinema.Servico;
using GerenciadorDeCinema.TesteDeUnidade.Builders;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GerenciadorDeCinema.TesteDeUnidade.Validators
{
    public class SessaoValidatorTest
    {
        [Fact]
        public void Deve_retornar_vazio_quando_sessao_for_valida()
        {
            //Arrange
            var s = new SessaoBuilder().sessao;

            var mockRepo = new Mock<ISessaoRepositorio>();
            var validator = new SessaoValidator(mockRepo.Object);

            //Act
            var resultValidation = validator.ValidarSessao(s);

            //Assert
            resultValidation.Should().Be(string.Empty);
        }

        [Fact]
        public void Deve_retornar_com_valor_quando_inicio_for_menor_que_o_minimo()
        {
            //Arrange
            var s = new SessaoBuilder().sessao;
            s.Inicio = DateTime.UtcNow;

            var mockRepo = new Mock<ISessaoRepositorio>();
            var validator = new SessaoValidator(mockRepo.Object);

            //Act
            var resultValidation = validator.ValidarSessao(s);

            //Assert
            resultValidation.Should().Be("A sessão precisa ser criada com mais de 10 dias de antecedência.");
        }

        [Fact]
        public void Deve_retornar_com_valor_quando_inicio_for_invalido()
        {
            //Arrange
            var s = new Sessao { Id = Guid.NewGuid(), FilmeId = new FilmeBuilder().filme.Id, SalaId = Guid.NewGuid(), Animacao = (Dominio.Enums.EAnimacao)2, Audio = (Dominio.Enums.EAudio)1, ValorIngresso = (decimal)7.50 };

            var mockRepo = new Mock<ISessaoRepositorio>();
            var validator = new SessaoValidator(mockRepo.Object);

            //Act
            var resultValidation = validator.ValidarSessao(s);

            //Assert
            resultValidation.Should().Be("A sessão precisa ser criada com mais de 10 dias de antecedência.");
        }

        [Fact]
        public void Deve_retornar_com_valor_quando_animacao_for_fora_do_enum()
        {
            //Arrange
            var s = new SessaoBuilder().sessao;
            s.Animacao = (Dominio.Enums.EAnimacao)8;

            var mockRepo = new Mock<ISessaoRepositorio>();
            var validator = new SessaoValidator(mockRepo.Object);

            //Act
            var resultValidation = validator.ValidarSessao(s);

            //Assert
            resultValidation.Should().Be("Campo inválido.");
        }

        [Fact]
        public void Deve_retornar_com_valor_quando_audio_for_invalido()
        {
            //Arrange
            var s = new SessaoBuilder().sessao;
            s.Audio = (Dominio.Enums.EAudio)16;

            var mockRepo = new Mock<ISessaoRepositorio>();
            var validator = new SessaoValidator(mockRepo.Object);

            //Act
            var resultValidation = validator.ValidarSessao(s);

            //Assert
            resultValidation.Should().Be("Campo inválido.");
        }

        [Fact]
        public void Deve_retornar_com_valor_quando_ingresso_for_invalido()
        {
            //Arrange
            var s = new Sessao { Id = Guid.NewGuid(), Inicio = DateTime.UtcNow.AddDays(11), FilmeId = new FilmeBuilder().filme.Id, SalaId = Guid.NewGuid(), Animacao = (Dominio.Enums.EAnimacao)2, Audio = (Dominio.Enums.EAudio)1, };

            var mockRepo = new Mock<ISessaoRepositorio>();
            var validator = new SessaoValidator(mockRepo.Object);

            //Act
            var resultValidation = validator.ValidarSessao(s);

            //Assert
            resultValidation.Should().Be("Campo requirido.");
        }

        [Fact]
        public void Deve_retornar_com_valor_quando_ingresso_for_menor_que_zero()
        {
            //Arrange
            var s = new SessaoBuilder().sessao;
            s.ValorIngresso = -1;

            var mockRepo = new Mock<ISessaoRepositorio>();
            var validator = new SessaoValidator(mockRepo.Object);

            //Act
            var resultValidation = validator.ValidarSessao(s);

            //Assert
            resultValidation.Should().Be("O valor do ingresso não pode ser menor que R$0,00.");
        }
    }
}

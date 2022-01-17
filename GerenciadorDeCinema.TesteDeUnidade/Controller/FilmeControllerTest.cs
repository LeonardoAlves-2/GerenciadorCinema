using FluentAssertions;
using GerenciadorDeCinema.Api.Controllers;
using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using GerenciadorDeCinema.Servico.Interfaces;
using GerenciadorDeCinema.TesteDeUnidade.Builders;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GerenciadorDeCinema.TesteDeUnidade.Controller
{
    public class FilmeControllerTest
    {
        private readonly FilmeController _filmeController;
        public FilmeControllerTest(FilmeController filmeController)
        {
            _filmeController = filmeController;
        }

        /*[Fact]
        public void Deve_retornar_true_quando_filme_for_valido()
        {
            //Arrange
            Filme f = new FilmeBuilder().filme;
            var mockRepo = new Mock<IFilmeRepositorio>();
            mockRepo.Setup(repo => repo.Adicionar(It.IsAny<Filme>())).Verifiable();

            //Act
            _ = _filmeController.Adicionar(f);

            //Assert
            mockRepo.Verify();
        }*/
    }
}

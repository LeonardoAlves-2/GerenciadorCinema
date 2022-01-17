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
        [Fact]
        public void Adicionar_deve_retornar_true_quando_filme_for_valido()
        {
            //Arrange
            Filme f = new FilmeBuilder().filme;
            var mockFilmeService = new Mock<IFilmeService>();
            var mockFilmeValidator = new Mock<IFilmeValidator>();
            var mockSessaoService = new Mock<ISessaoService>();
            mockFilmeService.Setup(repo => repo.Adicionar(It.IsAny<Filme>())).Verifiable();
            var controller = new FilmeController(mockFilmeService.Object, mockFilmeValidator.Object, mockSessaoService.Object);

            //Act
            _ = controller.Adicionar(f);

            //Assert
            mockFilmeService.Verify();
        }

        [Fact]
        public void Remover_deve_retornar_true_quando_filme_for_removido()
        {
            //Arrange
            Filme f = new FilmeBuilder().filme;
            var mockFilmeService = new Mock<IFilmeService>();
            var mockFilmeValidator = new Mock<IFilmeValidator>();
            var mockSessaoService = new Mock<ISessaoService>();
            mockFilmeService.Setup(repo => repo.Remover(It.IsAny<Filme>())).Verifiable();
            var controller = new FilmeController(mockFilmeService.Object, mockFilmeValidator.Object, mockSessaoService.Object);

            //Act
            _ = controller.Remover(f.Id);

            //Assert
            mockFilmeService.Verify();
        }

        [Fact]
        public void Remover_deve_retornar_true_quando_filme_for_editado()
        {
            //Arrange
            Filme f = new FilmeBuilder().filme;
            var mockFilmeService = new Mock<IFilmeService>();
            var mockFilmeValidator = new Mock<IFilmeValidator>();
            var mockSessaoService = new Mock<ISessaoService>();
            mockFilmeService.Setup(repo => repo.Editar(It.IsAny<Filme>())).Verifiable();
            var controller = new FilmeController(mockFilmeService.Object, mockFilmeValidator.Object, mockSessaoService.Object);

            //Act
            _ = controller.Editar(f, f.Id);

            //Assert
            mockFilmeService.Verify();
        }
    }
}

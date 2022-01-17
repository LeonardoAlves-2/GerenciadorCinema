using GerenciadorDeCinema.Api.Controllers;
using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Servico.Interfaces;
using GerenciadorDeCinema.TesteDeUnidade.Builders;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GerenciadorDeCinema.TesteDeUnidade.Controller
{
    public class SessaoControllerTest
    {
        [Fact]
        public void Listar_deve_retornar_true()
        {
            //Arrange
            var mockSessaoService = new Mock<ISessaoService>();
            var mockSessaoValidator = new Mock<ISessaoValidator>();
            var mockFilmeService = new Mock<IFilmeService>();
            mockSessaoService.Setup(repo => repo.ListarSessoes()).Verifiable();
            var controller = new SessaoController(mockSessaoService.Object, mockSessaoValidator.Object, mockFilmeService.Object);

            //Act
            _ = controller.Listar();

            //Assert
            mockFilmeService.Verify();
        }

        [Fact]
        public void Adicionar_deve_retornar_true_quando_sessao_for_valida()
        {
            //Arrange
            Sessao s = new SessaoBuilder().sessao;

            var mockSessaoService = new Mock<ISessaoService>();
            var mockSessaoValidator = new Mock<ISessaoValidator>();
            var mockFilmeService = new Mock<IFilmeService>();
            mockSessaoService.Setup(repo => repo.Adicionar(It.IsAny<Sessao>())).Verifiable();
            var controller = new SessaoController(mockSessaoService.Object, mockSessaoValidator.Object, mockFilmeService.Object);

            //Act
            _ = controller.Adicionar(s);

            //Assert
            mockFilmeService.Verify();
        }

        [Fact]
        public void Deletar_deve_retornar_true_quando_sessao_for_valida()
        {
            //Arrange
            Sessao s = new SessaoBuilder().sessao;

            var mockSessaoService = new Mock<ISessaoService>();
            var mockSessaoValidator = new Mock<ISessaoValidator>();
            var mockFilmeService = new Mock<IFilmeService>();
            mockSessaoService.Setup(repo => repo.Remover(It.IsAny<Sessao>())).Verifiable();
            var controller = new SessaoController(mockSessaoService.Object, mockSessaoValidator.Object, mockFilmeService.Object);

            //Act
            _ = controller.Remover(s.Id);

            //Assert
            mockFilmeService.Verify();
        }
    }
}

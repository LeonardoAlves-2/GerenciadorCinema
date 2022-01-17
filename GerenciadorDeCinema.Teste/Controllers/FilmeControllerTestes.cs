using GerenciadorDeCinema.Api.Controllers;
using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using GerenciadorDeCinema.Servico.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GerenciadorDeCinema.Teste.Controllers
{
    public class FilmeControllerTestes
    {
        private FilmeController _filmeController;
        public FilmeControllerTestes()
        {
            _filmeController = new FilmeController(new Mock<IFilmeService>().Object, new Mock<IFilmeValidator>().Object, new Mock<ISessaoService>().Object);
        }

        [Fact]
        public void DeveRetornarTrueQuandoFilmeEValido()
        {
            var filme = new Filme { Id = Guid.NewGuid(), Titulo = "Teste", Duracao = 120, Descricao = "Um teste" };

            var filmeValido = _filmeController.Adicionar(filme);

            filmeValido.Status.Equals(200);
        }

        [Fact]
        public void DeveRetornarTrueQuandoFilmeEInvalido()
        {
            var filme = new Filme { Id = Guid.NewGuid(), Titulo = "", Duracao = 120, Descricao = "Um teste" };

            var filmeInvalido = _filmeController.Adicionar(filme);

            filmeInvalido.Status.Equals(400);
        }
    }
}

using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using GerenciadorDeCinema.Servico.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Servico
{
    public class SalaService : ISalaService
    {
        private readonly ISalaRepositorio _salaRepositorio;
        public SalaService(ISalaRepositorio salaRepositorio)
        {
            _salaRepositorio = salaRepositorio;
        }

        public IEnumerable<Sala> ListarSalas()
        {
            var salas = _salaRepositorio.Listar();
            return salas;
        }

        public async Task Adicionar(Sala sala)
        {
            await _salaRepositorio.Adicionar(sala);
        }

        public async Task Editar(Sala sala)
        {
            await _salaRepositorio.Editar(sala);
        }

        public async Task Remover(Sala sala)
        {
            await _salaRepositorio.Remover(sala);
        }
    }
}

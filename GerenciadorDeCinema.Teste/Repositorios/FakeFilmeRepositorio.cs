using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Teste.Repositorios
{
    public class FakeFilmeRepositorio //: IFilmeRepositorio
    {
        /*IList<Filme> filmes = new List<Filme>
            {
                new Filme("b0902376-4065-412a-a16d-066b4ab8d66f","filme1", (Dominio.Enums.ECategoria)2, 0, 87, "filme 1", (Dominio.Enums.EAnimacao)2, (Dominio.Enums.EAudio)1),
                new Filme("filme2", (Dominio.Enums.ECategoria)1, 0, 72, "filme 1", (Dominio.Enums.EAnimacao)2, (Dominio.Enums.EAudio)1)
            };

        public Task Adicionar(Filme item)
        {
            if(item.Titulo == "Titulo repetido")
            {
                return Task.FromResult("Titulo já adicionado");
            }
            return Task.FromResult(item);
        }

        public Task Editar(Filme item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Filme> Listar()
        {
            return filmes;
        }

        public Task<Filme> ListarPeloId(Guid itemId)
        {
            if(filmes.Id == itemId)
                return filmes;
        }

        public Task Remover(Filme item)
        {
            
        }*/
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces
{
    public interface IRepositorioBase<T> where T : class
    {
        Task Adicionar(T item);
        Task Remover(T item);
        Task Editar(T item);
        IEnumerable<T> Listar();
    }
}
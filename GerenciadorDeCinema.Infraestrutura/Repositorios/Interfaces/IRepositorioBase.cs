using System;
using System.Collections.Generic;

namespace GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces
{
    public interface IRepositorioBase<T> where T : class
    {
        void Adicionar(T item);
        void Remover(T item);
        void Editar(T item);
        void ListarPorTitulo(T item);
        IEnumerable<T> Listar();
    }
}
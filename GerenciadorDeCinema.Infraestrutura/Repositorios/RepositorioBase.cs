using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces
{
    public abstract class RepositorioBase<T> : IRepositorioBase<T> where T : class

    {
        protected readonly DbContext _context;

        public RepositorioBase(DbContext context)
        {
            _context = context;
        }
          
        public virtual void Adicionar(T item)
        {
            _context.Set<T>().Add(item);
            _context.SaveChanges();
        }

        public virtual void Remover(T item)
        {
            _context.Set<T>().Remove(item);
            _context.SaveChanges();
        }

        public virtual void Editar(T item)
        {
            _context.Set<T>().Update(item);
            _context.SaveChanges();
        }

        public virtual IEnumerable<T> Listar()
        {
            return _context.Set<T>();
        }
    }
}
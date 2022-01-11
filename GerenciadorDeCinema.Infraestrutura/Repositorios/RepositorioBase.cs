using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces
{
    public abstract class RepositorioBase<T> : IRepositorioBase<T> where T : class

    {
        protected readonly DbContext _context;

        public RepositorioBase(DbContext context)
        {
            _context = context;
        }
          
        public async virtual Task Adicionar(T item)
        {
            await _context.Set<T>().AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async virtual Task Remover(T item)
        {
            _context.Set<T>().Remove(item);
            await _context.SaveChangesAsync();
        }

        public async virtual Task Editar(T item)
        {
            _context.Set<T>().Update(item);
            await _context.SaveChangesAsync();
        }

        public  virtual IEnumerable<T> Listar()
        {
            return  _context.Set<T>().AsNoTracking();
        }
    }
}
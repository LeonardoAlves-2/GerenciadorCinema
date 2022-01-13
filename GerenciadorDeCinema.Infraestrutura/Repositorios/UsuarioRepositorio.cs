using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeCinema.Infraestrutura.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        protected readonly DbContext _context;
        public UsuarioRepositorio(DbContext context)
        {
            _context = context;
        }
        public async Task<bool> Logar(Usuario usuario)
        {
            var loginValido = await _context.Set<Usuario>().FirstOrDefaultAsync(e => e.Email == usuario.Email && e.PasswordHash == usuario.PasswordHash);

            return loginValido != null;
        }
    }
}

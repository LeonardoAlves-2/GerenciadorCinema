using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCinema.Dominio.Entidades
{
    public class Usuario : EntidadeBase
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}

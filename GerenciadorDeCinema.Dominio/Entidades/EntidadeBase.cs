using System;

namespace GerenciadorDeCinema.Dominio.Entidades
{
    public abstract class EntidadeBase
    {
        public Guid Id { get; set; }
        public EntidadeBase()
        {
            Id = Guid.NewGuid();
        }
    }
}
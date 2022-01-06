using FluentValidation;
using GerenciadorDeCinema.Dominio.Entidades;
using System;

namespace Cinema.Domain.Validators
{
    public class SessaoValidator : AbstractValidator<Sessao>
    {
        public SessaoValidator()
        {
            RuleFor(p => p.InicioSessao)
            .GreaterThan(DateTime.UtcNow.AddDays(10))
            .WithMessage("A sessão precisa ser criada com mais de 10 dias de antecedência.");
        }
    }
}
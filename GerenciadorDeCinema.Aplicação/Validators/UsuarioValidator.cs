using FluentValidation;
using GerenciadorDeCinema.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCinema.Servico.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(p => p.Email).Cascade(CascadeMode.Stop)
            .NotEmpty().WithMessage("Campo requirido.")
            .EmailAddress().WithMessage("O {PropertyName} está inválido.");

            RuleFor(p => p.PasswordHash).Cascade(CascadeMode.Stop)
            .NotEmpty().WithMessage("Campo requirido.");
        }
    }
}

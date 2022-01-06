using FluentValidation;
using GerenciadorDeCinema.Dominio.Entidades;

namespace Cinema.Domain.Validators
{
    public class FilmeValidator : AbstractValidator<Filme>
    {
        public FilmeValidator()
        {
            RuleFor(p => p.Titulo)
            .NotEmpty().NotNull()
            .WithMessage("O {PropertyName} não pode estar vazia.");

            RuleFor(p => p.Categoria)
            .IsInEnum()
            .WithMessage("A {PropertyName} precisa ter um valir válido.");

            RuleFor(p => p.Classificacao_Indicativa)
            .IsInEnum()
            .WithMessage("A {PropertyName} precisa ter um valor válido.");

            RuleFor(p => p.Duracao)
            .NotEmpty().NotNull()
            .WithMessage("A {PropertyName} não pode estar vazia.");

            RuleFor(p => p.Sinopse)
            .NotEmpty().NotNull()
            .WithMessage("A {PropertyName} não pode estar vazia.");

            RuleFor(p => p.Animacao)
            .IsInEnum()
            .WithMessage("O tipo de {PropertyName} precisa ter um valor válido.");

            RuleFor(p => p.Audio)
            .IsInEnum()
            .WithMessage("O tipo de {PropertyName} precisa ser um valor válido.");
        }
    }
}
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
            .IsInEnum().NotEmpty().NotNull()
            .WithMessage("A {PropertyName} precisa ter um valor válido.");

            RuleFor(p => p.Classificacao_Indicativa)
            .IsInEnum().NotEmpty().NotNull()
            .WithMessage("A {PropertyName} precisa ter um valor válido.");

            RuleFor(p => p.Duracao)
            .NotEmpty().NotNull()
            .WithMessage("A {PropertyName} não pode estar vazia.");

            RuleFor(p => p.Sinopse)
            .NotEmpty().NotNull()
            .WithMessage("A {PropertyName} não pode estar vazia.");

            RuleFor(p => p.Animacao)
            .IsInEnum().NotEmpty().NotNull()
            .WithMessage("O tipo de {PropertyName} precisa ter um valor válido.");

            RuleFor(p => p.Audio)
            .IsInEnum().NotEmpty().NotNull()
            .WithMessage("O tipo de {PropertyName} precisa ser um valor válido.");
        }
    }
}
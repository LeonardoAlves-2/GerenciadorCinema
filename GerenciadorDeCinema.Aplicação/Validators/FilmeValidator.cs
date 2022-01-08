using FluentValidation;
using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GerenciadorDeCinema.Servico.Validators
{
    public class FilmeValidator : AbstractValidator<Filme>
    {
        private readonly IFilmeRepositorio _filmeRepositorio;
        public FilmeValidator(IFilmeRepositorio filmeRepositorio)
        {
            _filmeRepositorio = filmeRepositorio;
        }
        public FilmeValidator()
        {
            RuleFor(p => p.Titulo)
            .NotEmpty().Must(IsUnique)
            .WithMessage("O {PropertyName} não pode estar vazia.");

            RuleFor(p => p.Categoria)
            .IsInEnum().NotEmpty()
            .WithMessage("A {PropertyName} precisa ter um valor válido.");

            RuleFor(p => p.Classificacao_Indicativa)
            .IsInEnum().NotEmpty()
            .WithMessage("A {PropertyName} precisa ter um valor válido.");

            RuleFor(p => p.DuracaoEmMinutos)
            .NotEmpty().NotNull()
            .WithMessage("A {PropertyName} não pode estar vazia.");

            RuleFor(p => p.Sinopse)
            .NotEmpty().NotNull()
            .WithMessage("A {PropertyName} não pode estar vazia.");

            RuleFor(p => p.Animacao)
            .IsInEnum().NotEmpty()
            .WithMessage("O tipo de {PropertyName} precisa ter um valor válido.");

            RuleFor(p => p.Audio)
            .IsInEnum().NotEmpty()
            .WithMessage("O tipo de {PropertyName} precisa ser um valor válido.");


        }

        private bool IsUnique(string titulo)
        {
            var filmeUnico = _filmeRepositorio.Listar()
                .Where(x => x.Titulo.ToLower() == titulo.ToLower())
                .SingleOrDefault();

            if (filmeUnico == null)
                return true;

            return false;
        }
    }
}
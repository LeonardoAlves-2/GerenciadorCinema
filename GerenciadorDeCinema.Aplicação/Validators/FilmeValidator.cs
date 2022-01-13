using FluentValidation;
using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura;
using GerenciadorDeCinema.Infraestrutura.Repositorios;
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

            RuleFor(p => p.Imagem)
            .NotEmpty().WithMessage("A {PropertyName} não pode estar vazia.");

            RuleFor(p => p.Titulo)
            .NotEmpty().WithMessage("O {PropertyName} não pode estar vazio.")
            .Must(IsUnique).WithMessage("O {PropertyName} já existe.");

            RuleFor(p => p.Duracao)
            .NotEmpty().WithMessage("A {PropertyName} não pode estar vazia.")
            .GreaterThan(0).WithMessage("A {PropertyName} precisa ser maior que zero.");

            RuleFor(p => p.Descricao)
            .NotEmpty().WithMessage("A {PropertyName} não pode estar vazia.");
        }

        private bool IsUnique(Filme filme, string titulo)
        {
            var filmeUnico = _filmeRepositorio.Listar()
                .FirstOrDefault(x => x.Titulo.ToLower() == titulo.ToLower());

            if (filmeUnico == null)
                return true;

            return filme.Id == filmeUnico.Id;
        }
    }
}
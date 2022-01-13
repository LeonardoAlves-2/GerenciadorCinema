using FluentValidation;
using GerenciadorDeCinema.Dominio.Entidades;
using GerenciadorDeCinema.Infraestrutura.Repositorios.Interfaces;
using System;
using System.Linq;

namespace GerenciadorDeCinema.Servico.Validators
{
    public class SessaoValidator : AbstractValidator<Sessao>
    {
        private readonly ISessaoRepositorio _sessaoRepositorio;

        public SessaoValidator(ISessaoRepositorio sessaoRepositorio)
        {
            _sessaoRepositorio = sessaoRepositorio;

            RuleFor(p => p.Inicio)
            .GreaterThan(DateTime.UtcNow.AddDays(10)).WithMessage("A sessão precisa ser criada com mais de 10 dias de antecedência.")
            .Must(DataSessaoValidar).WithMessage("A sala já está ocupada neste horário.");

            RuleFor(p => p.Animacao)
            .IsInEnum().WithMessage("O tipo de {PropertyName} precisa ter um valor válido.")
            .NotEmpty().WithMessage("A {PropertyName} não pode estar vazia.");

            RuleFor(p => p.Audio)
            .IsInEnum().WithMessage("O tipo de {PropertyName} precisa ser um valor válido.")
            .NotEmpty().WithMessage("O {PropertyName} não pode estar vazia.");

            RuleFor(p => p.ValorIngresso)
            .GreaterThan(0).WithMessage("O valor do ingresso não pode ser menor que R$0,00.");
        }

        private bool DataSessaoValidar(Sessao sessao, DateTime inicio)
        {
            var sessaoValida = _sessaoRepositorio.Listar().FirstOrDefault(x => x.Inicio >= inicio && inicio <= x.Final && x.SalaId == sessao.SalaId);

            if (sessaoValida == null)
                return true;

            return sessaoValida.Id == sessao.Id;
        }
    }
}
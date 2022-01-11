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
        }

        private bool DataSessaoValidar(Sessao sessao, DateTime inicio)
        {
            var sessaoValida = _sessaoRepositorio.Listar().FirstOrDefault(x => x.Inicio >= inicio && inicio <= x.Final && x.Sala == sessao.Sala);

            if (sessaoValida == null)
                return true;

            return sessaoValida.Id == sessao.Id;
        }
    }
}
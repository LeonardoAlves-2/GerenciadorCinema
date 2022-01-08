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
        }

        public SessaoValidator()
        {
            RuleFor(p => p.InicioSessao)
            .GreaterThan(DateTime.UtcNow.AddDays(10))
            .WithMessage("A sessão precisa ser criada com mais de 10 dias de antecedência.")
            .Must(DataSessaoValidar).WithMessage("A sala já está ocupada neste horário.");

            
        }

        public bool DataSessaoValidar(Sessao sessao, DateTime inicioSessao)
        {
            var sessaoValida = _sessaoRepositorio.Listar()
                .Where(x => x.InicioSessao >= inicioSessao && x.FinalSessao <= inicioSessao && x.SalaSessao == sessao.SalaSessao)
                .SingleOrDefault();

            if (sessaoValida == null)
                return true;

            return sessaoValida.Id == sessao.Id;
        }
    }
}
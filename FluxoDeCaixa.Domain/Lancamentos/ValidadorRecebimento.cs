using System;
using FluentValidation;

namespace FluxoDeCaixa.Domain.Lancamentos
{
    public class ValidadorRecebimento : AbstractValidator<Recebimento>
    {
        public ValidadorRecebimento()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(recebimento => recebimento.Descricao)
                    .NotEmpty()
                    .WithMessage("Descrição é Obrigatória");

            RuleFor(recebimento => recebimento.Documento)
                    .NotEmpty()
                    .WithMessage("Documento é Obrigatório");

            RuleFor(recebimento => recebimento.ContaDestino)
                    .NotNull()
                    .NotEmpty()
                    .WithMessage("Dados da conta de destino é Obrigatório");

            RuleFor(recebimento => recebimento.ValorLancamento)
                    .GreaterThanOrEqualTo(0)
                    .WithMessage("Lançamento deve ser maior que zero.");

            RuleFor(recebimento => recebimento.ValorEncargos)
                    .LessThan(0)
                    .WithMessage("Encargos não podem ser menor que zero.");

            RuleFor(recebimento => recebimento.DataDeLancamento)
                    .GreaterThanOrEqualTo(recebimento => DateTime.Now.Date)
                    .WithMessage("Encargos não podem ser menor que zero.");
        }
    }
}
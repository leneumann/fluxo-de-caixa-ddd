using System;
using FluentValidation;
using FluxoDeCaixa.Domain.Lancamentos;

namespace FluxoDeCaixa.Application.Lancamentos
{
    public class ValidadorCommandPagamento : AbstractValidator<CriarPagamentoCommand>
    {
        public ValidadorCommandPagamento()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(pagamento => pagamento.Descricao)
                        .NotEmpty()
                        .WithMessage("Descrição do pagamento é Obrigatória");

            RuleFor(pagamento => pagamento.Documento)
                        .NotEmpty()
                        .WithMessage("Documento do pagamento é Obrigatório");

            RuleFor(pagamento => pagamento.ContaDestino)
                        .NotNull()
                        .NotEmpty()
                        .WithMessage("Dados da conta de destino do pagamento são Obrigatórios");

            RuleFor(pagamento => pagamento.ValorLancamento)
                        .GreaterThan(0)
                        .WithMessage("Valor de Lançamento do pagamento deve ser maior que zero.");

            RuleFor(pagamento => pagamento.ValorEncargos)
                        .GreaterThanOrEqualTo(0)
                        .WithMessage("Encargos do pagamento não podem ser menor que zero.");

            RuleFor(pagamento => pagamento.DataDeLancamento)
                        .GreaterThanOrEqualTo(pagamento => DateTime.Now.Date)
                        .WithMessage("A data de lançamento do pagamento não pode ser retroativo.");

            RuleFor(pagamento => pagamento.TipoDeConta)
                        .NotNull()
                        .NotEmpty()
                        .WithMessage("O Tipo de Conta informado para este pagamento está inválido");
        }
    }
}
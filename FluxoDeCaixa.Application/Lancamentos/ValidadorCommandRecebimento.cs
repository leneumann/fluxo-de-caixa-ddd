using System;
using FluentValidation;
using FluxoDeCaixa.Domain.Lancamentos;

namespace FluxoDeCaixa.Application.Lancamentos
{
    public class ValidadorCommandRecebimento : AbstractValidator<CriarRecebimentoCommand>
    {
        public ValidadorCommandRecebimento()
        {
            CascadeMode = CascadeMode.StopOnFirstFailure;

            RuleFor(recebimento => recebimento.Descricao)
                        .NotEmpty()
                        .WithMessage("Descrição do recebimento é Obrigatória");

            RuleFor(recebimento => recebimento.Documento)
                        .NotEmpty()
                        .WithMessage("Documento do recebimento é Obrigatório");

            RuleFor(recebimento => recebimento.ContaDestino)
                        .NotNull()
                        .NotEmpty()
                        .WithMessage("Dados da conta de destino do recebimento são Obrigatórios");

            RuleFor(recebimento => recebimento.ValorLancamento)
                        .GreaterThan(0)
                        .WithMessage("Valor do lançamento do recebimento deve ser maior que zero.");

            RuleFor(recebimento => recebimento.ValorEncargos)
                        .GreaterThanOrEqualTo(0)
                        .WithMessage("Encargos de recebimento não podem ser menor que zero.");

            RuleFor(recebimento => recebimento.DataDeLancamento)
                        .GreaterThanOrEqualTo(recebimento => DateTime.Now.Date)
                        .WithMessage("A data de lançamento do recebimento não pode ser retroativo.");

            RuleFor(pagamento => pagamento.TipoDeConta)
                        .NotNull()
                        .NotEmpty()
                        .WithMessage("O Tipo de Conta informado para este pagamento está inválido");
        }
    }
}
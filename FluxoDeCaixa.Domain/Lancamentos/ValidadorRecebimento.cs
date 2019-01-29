using System;
using FluentValidation;

namespace FluxoDeCaixa.Domain.Lancamentos
{
    public class ValidadorRecebimento : AbstractValidator<Recebimento>
    {
        public ValidadorRecebimento()
        {
            RuleFor(recebimento => recebimento.DataDeLancamento)
                    .GreaterThanOrEqualTo(recebimento => DateTime.Now.Date)
                    .WithMessage("A data de lançamento do recebimento não pode ser retroativo.");
        }
    }
}
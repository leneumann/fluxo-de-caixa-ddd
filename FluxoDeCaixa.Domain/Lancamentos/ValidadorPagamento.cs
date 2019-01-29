using System;
using FluentValidation;

namespace FluxoDeCaixa.Domain.Lancamentos
{
    public class ValidadorPagamento : AbstractValidator<Pagamento>
    {
        public ValidadorPagamento()
        {
            RuleFor(pagamento => pagamento.DataDeLancamento)
                    .GreaterThanOrEqualTo(pagamento => DateTime.Now.Date)
                    .WithMessage("A data de lançamento do pagamento não pode ser retroativo.");
        }
    }
}
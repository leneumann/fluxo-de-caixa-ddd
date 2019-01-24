using System;

namespace FluxoDeCaixa.Domain.ValueObjects
{
    public class Lancamento
    {
        public DateTime DataDoLancamento { get; set; }
        public decimal ValorDoLancamento { get; set; }
    }
}
using System;

namespace FluxoDeCaixa.Domain.Entities
{
    public class LancamentoFinanceiro
    {
        public TiposDeLancamento Tipo { get; set; }
        public string Descricao { get; set; }  
        public string ContaDestino { get; set; }
        public string BancoDestino { get; set; }
        public TiposDeConta TipoDeConta { get; set; }
        public string Documento { get; set; }
        public decimal ValorLancamento { get; set; }
        public decimal ValorEncargos { get; set; }
        public DateTime DataDeLancamento { get; set; }

    }
}
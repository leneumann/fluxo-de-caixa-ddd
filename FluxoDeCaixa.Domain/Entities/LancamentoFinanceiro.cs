using System;

namespace FluxoDeCaixa.Domain.Entities
{
    public class LancamentoFinanceiro
    {
        public LancamentoFinanceiro(TiposDeLancamento tipo,
                                    string descricao,
                                    string contaDestino,
                                    string bancoDestino,
                                    TiposDeConta tipoDeConta,
                                    string documento,
                                    decimal valorLancamento,
                                    decimal valorEncargos,
                                    DateTime dataDeLancamento)
        {
            Tipo = tipo;
            Descricao = descricao;
            ContaDestino = contaDestino;
            BancoDestino = bancoDestino;
            TipoDeConta = tipoDeConta;
            Documento = documento;
            ValorLancamento = valorLancamento;
            ValorEncargos = valorEncargos;
            DataDeLancamento = dataDeLancamento;
        }

        public TiposDeLancamento Tipo { get; private set; }
        public string Descricao { get; private set; }
        public string ContaDestino { get; private set; }
        public string BancoDestino { get; private set; }
        public TiposDeConta TipoDeConta { get; private set; }
        public string Documento { get; private set; }
        public decimal ValorLancamento { get; private set; }
        public decimal ValorEncargos { get; private set; }
        public DateTime DataDeLancamento { get; private set; }

    }
}
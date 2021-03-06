using System;

namespace FluxoDeCaixa.Domain.Lancamentos
{
    public class Pagamento:Entity
    {
        public Pagamento(
                                    string descricao,
                                    ContaBancaria contaDestino,
                                    string documento,
                                    decimal valorLancamento,
                                    decimal valorEncargos,
                                    DateTime dataDeLancamento)
        {

            Descricao = descricao;
            ContaDestino = contaDestino;
            Documento = documento;
            ValorLancamento = valorLancamento;
            ValorEncargos = valorEncargos;
            DataDeLancamento = dataDeLancamento;

            Validate(this, new ValidadorPagamento());
        }

        public string Descricao { get; private set; }
        public ContaBancaria ContaDestino { get; private set; }
        public string Documento { get; private set; }
        public decimal ValorLancamento { get; private set; }
        public decimal ValorEncargos { get; private set; }
        public DateTime DataDeLancamento { get; private set; }

    }
}
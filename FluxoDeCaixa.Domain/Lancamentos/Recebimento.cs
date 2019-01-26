using System;

namespace Lancamentos
{
    public class Recebimento
    {
        public Recebimento(
                                    string descricao,
                                    string contaDestino,
                                    string bancoDestino,
                                    TiposDeConta tipoDeConta,
                                    string documento,
                                    decimal valorLancamento,
                                    decimal valorEncargos,
                                    DateTime dataDeLancamento)
        {

            Descricao = descricao;
            ContaDestino = contaDestino;
            BancoDestino = bancoDestino;
            TipoDeConta = tipoDeConta;
            Documento = documento;
            ValorLancamento = valorLancamento;
            ValorEncargos = valorEncargos;
            DataDeLancamento = dataDeLancamento;
        }

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
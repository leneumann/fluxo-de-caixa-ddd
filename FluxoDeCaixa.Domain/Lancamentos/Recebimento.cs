using System;


namespace FluxoDeCaixa.Domain.Lancamentos
{
    public class Recebimento:Entity
    {
        public Recebimento(
                                    string descricao,
                                    Conta contaDestino,
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

            Validate(this, new ValidadorRecebimento());
        }

        public string Descricao { get; private set; }
        public Conta ContaDestino { get; private set; }
        public string Documento { get; private set; }
        public decimal ValorLancamento { get; private set; }
        public decimal ValorEncargos { get; private set; }
        public DateTime DataDeLancamento { get; private set; }

    }
}
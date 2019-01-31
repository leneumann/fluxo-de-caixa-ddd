using System;

namespace FluxoDeCaixa.Domain.Lancamentos
{
    public class ContaBancaria
    {
        public ContaBancaria(string contaDestino, string bancoDestino, string tipoDeConta)
        {
            ContaDestino = contaDestino;
            BancoDestino = bancoDestino;
            TipoDeConta = tipoDeConta;
        }

        public string ContaDestino { get; private set; }
        public string BancoDestino { get; private set; }
        public string TipoDeConta { get; private set; }
    }
}
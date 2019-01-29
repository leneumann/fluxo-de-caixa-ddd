using System;
using FluxoDeCaixa.Domain.Lancamentos;

namespace FluxoDeCaixa.Application.Lancamentos
{
 public class CriarPagamentoCommand:Command
 {
        public CriarPagamentoCommand(string descricao, string documento, decimal valorLancamento, decimal valorEncargos, DateTime dataDeLancamento, string contaDestino, string bancoDestino, TiposDeConta tipoDeConta)
        {
            Descricao = descricao;
            Documento = documento;
            ValorLancamento = valorLancamento;
            ValorEncargos = valorEncargos;
            DataDeLancamento = dataDeLancamento;
            ContaDestino = contaDestino;
            BancoDestino = bancoDestino;
            TipoDeConta = tipoDeConta;

            Validate(this,new ValidadorCommandPagamento());
        }

        public string Descricao { get; set; }
        public string Documento { get; set; }
        public decimal ValorLancamento { get; set; }
        public decimal ValorEncargos { get; set; }
        public DateTime DataDeLancamento { get; set; }
        public string ContaDestino { get; set; }
        public string BancoDestino { get; set; }
        public TiposDeConta TipoDeConta { get; set; }

    }   
}
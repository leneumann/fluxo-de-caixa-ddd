using System;
using FluentValidation;
using FluxoDeCaixa.Domain.Lancamentos;

namespace FluxoDeCaixa.Application.Lancamentos
{
    public class CriarRecebimentoCommand : Command
    {
        public override IValidator GetValidator() => new ValidadorCommandRecebimento();
        public string Descricao { get; set; }
        public string Documento { get; set; }
        public decimal ValorLancamento { get; set; }
        public decimal ValorEncargos { get; set; }
        public DateTime DataDeLancamento { get; set; }
        public string ContaDestino { get; set; }
        public string BancoDestino { get; set; }
        public string TipoDeConta { get; set; }
    }
}
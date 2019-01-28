using System;
using FluxoDeCaixa.Domain.Lancamentos;
using Xunit;

namespace FluxoDeCaixa.Tests.Lancamentos
{

    public class RecebimentoTests
    {
        [Fact]
        public void RecebimentoDeveEstarValido()
        {
            var contaDestino = new Conta("2", "23", TiposDeConta.Corrente);
            var recebimento = new Recebimento("Lancamento", contaDestino, "3345478827", 100m, 0m, DateTime.Now);


            Assert.True(recebimento.Valid);
        }

        [Fact]
        public void RecebimentoDeveEstarInvalido()
        {
            var contaDestino = new Conta("2", "23", TiposDeConta.Corrente);
            var recebimento = new Recebimento("", contaDestino, "3345478827", 100m, 0m, DateTime.Now.AddDays(-1));

            Assert.True(recebimento.Invalid);
        }

    }
}
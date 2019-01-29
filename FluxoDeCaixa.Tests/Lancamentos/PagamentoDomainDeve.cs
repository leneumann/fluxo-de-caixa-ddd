using System;
using FluxoDeCaixa.Domain.Lancamentos;
using Xunit;

namespace FluxoDeCaixa.Tests.Lancamentos
{
    public class PagamentoDomainDeve
    {
         [Fact]
        public void PagamentoDeveEstarValido()
        {
            var contaDestino = new Conta("2","23",TiposDeConta.Corrente);
            var pagamento = new Pagamento("Lancamento",contaDestino,"3345478827",100m,0m,DateTime.Now);
            
            Assert.True(pagamento.Valid);
        }

         [Fact]
        public void PagamentoDeveEstarInvalido()
        {
            var contaDestino = new Conta("2","23",TiposDeConta.Corrente);
            var pagamento = new Pagamento("",contaDestino,"3345478827",100m,0m,DateTime.Now.AddDays(-1));
            
            Assert.True(pagamento.Invalid);
        }
    }
}
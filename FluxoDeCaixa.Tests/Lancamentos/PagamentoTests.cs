using System;
using FluxoDeCaixa.Domain.Lancamentos;
using Xunit;

namespace FluxoDeCaixa.Tests.Lancamentos
{
    public class PagamentoTests
    {
         [Fact]
        public void PagamentoDeveEstarValido()
        {
            var contaDestino = new Conta("2","23",TiposDeConta.Corrente);
            var pagamento = new Pagamento("Lancamento",contaDestino,"3345478827",100m,0m,DateTime.Now);
            

            Assert.NotNull(pagamento);
        }

    }
}
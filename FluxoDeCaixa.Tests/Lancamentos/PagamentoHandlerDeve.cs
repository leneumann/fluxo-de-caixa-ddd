using System;
using FluxoDeCaixa.Application.Lancamentos;
using FluxoDeCaixa.Domain;
using FluxoDeCaixa.Domain.Lancamentos;
using Moq;
using Xunit;

namespace FluxoDeCaixa.Tests.Lancamentos
{
    public class PagamentoHandlerDeve
    {
        [Fact]
        public void Valido()
        {
            var mockRepositorio = new Mock<ILancamentoRepository>();
            mockRepositorio.Setup(x => x.InserirPagamento(It.IsAny<Pagamento>()));
            var handler = new LancamentoHandler(mockRepositorio.Object);
            var command = new CriarPagamentoCommand("Pagamento","343343",100m,0m,DateTime.Now,"2","231",TiposDeConta.Corrente);

            handler.Handle(command);

            Assert.False(handler.HasNotifications);
        }
    }
}
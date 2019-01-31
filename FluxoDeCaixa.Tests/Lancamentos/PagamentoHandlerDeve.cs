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
            var command = new CriarPagamentoCommand() { Descricao = "Pagamento", 
                                                        Documento = "343343", 
                                                        ValorLancamento = 100m, 
                                                        ValorEncargos = 0m, 
                                                        DataDeLancamento = 
                                                        DateTime.Now, 
                                                        ContaDestino = "2", 
                                                        BancoDestino = "231", 
                                                        TipoDeConta = "Corrente" };

            handler.Handle(command);

            Assert.False(handler.HasNotifications);
        }
    }
}
using System;
using FluxoDeCaixa.Application.Lancamentos;
using FluxoDeCaixa.Domain;
using FluxoDeCaixa.Domain.Lancamentos;
using Moq;
using Xunit;

namespace FluxoDeCaixa.Tests.Lancamentos
{
    public class RecebimentoHandlerDeve
    {
        [Fact]
        public void Valido()
        {
            var mockRepositorio = new Mock<ILancamentoRepository>();
            mockRepositorio.Setup(x => x.InserirRecebimento(It.IsAny<Recebimento>()));
            var handler = new LancamentoHandler(mockRepositorio.Object);
            var command = new CriarRecebimentoCommand() { Descricao = "Recebimento", 
                                                        Documento = "343343", 
                                                        ValorLancamento = 100m, 
                                                        ValorEncargos = 0m, 
                                                        DataDeLancamento = DateTime.Now, 
                                                        ContaDestino = "2", 
                                                        BancoDestino = "231", 
                                                        TipoDeConta = "Corrente" };
            handler.Handle(command);

            Assert.False(handler.HasNotifications);
        }
    }
}
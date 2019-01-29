using FluxoDeCaixa.Domain.Lancamentos;

namespace FluxoDeCaixa.Application.Lancamentos
{
    public class LancamentoHandler : NotificationContext,
    IHandler<CriarPagamentoCommand>,
    IHandler<CriarRecebimentoCommand>
    {
        private readonly ILancamentoRepository _repositorioLancamento;
        public LancamentoHandler(ILancamentoRepository repositorioLancamento)
        {
            _repositorioLancamento = repositorioLancamento;
        }
        public ICommandResult Handle(CriarPagamentoCommand command)
        {
            if (command.Invalid)
                return new CommandResult(false, "Não foi possível efetuar o lançamento");

            var contaDestino = new Conta(command.ContaDestino, command.BancoDestino, command.TipoDeConta);
            var pagamento = new Pagamento(command.Descricao, contaDestino, command.Documento, command.ValorLancamento, command.ValorEncargos, command.DataDeLancamento);

            if (pagamento.Invalid)
            {
                AddNotifications(pagamento.ValidationResult);
                return new CommandResult(false, "Não foi possível efetuar o lançamento");
            }
            _repositorioLancamento.InserirPagamento(pagamento);
            return new CommandResult(true, "Lançamento efetuado com sucesso.");
        }

        public ICommandResult Handle(CriarRecebimentoCommand command)
        {
            if (command.Invalid)
            {
                AddNotifications(command.ValidationResult);
                return new CommandResult(false, "Não foi possível efetuar o lançamento");
            }
            var contaDestino = new Conta(command.ContaDestino, command.BancoDestino, command.TipoDeConta);
            var recebimento = new Recebimento(command.Descricao, contaDestino, command.Documento, command.ValorLancamento, command.ValorEncargos, command.DataDeLancamento);
            if (recebimento.Invalid)
            {
                AddNotifications(recebimento.ValidationResult);
                return new CommandResult(false, "Não foi possível efetuar o lançamento");
            }
            _repositorioLancamento.InserirRecebimento(recebimento);

            return new CommandResult(true, "Lançamento efetuado com sucesso.");
        }
    }
}
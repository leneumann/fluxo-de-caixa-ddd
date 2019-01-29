namespace FluxoDeCaixa.Domain.Lancamentos
{
    public interface ILancamentoRepository
    {
        void InserirPagamento(Pagamento pagamento);
        void InserirRecebimento(Recebimento recebimento);
    }
}
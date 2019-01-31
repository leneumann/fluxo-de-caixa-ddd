using FluxoDeCaixa.Domain.Lancamentos;

namespace FluxoDeCaixa.Infrastructure.Lancamentos
{
    public class MongoDBLancamentosRepository : MongoDBRepository, ILancamentoRepository
    {
        public void InserirPagamento(Pagamento pagamento)
        {
            Database.GetCollection<Pagamento>("Lancamentos").InsertOne(pagamento);
        }

        public void InserirRecebimento(Recebimento recebimento)
        {
            Database.GetCollection<Recebimento>("Lancamentos").InsertOne(recebimento);
        }
    }
}
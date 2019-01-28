namespace FluxoDeCaixa.Domain.Lancamentos
{
    public class Conta
    {
        public Conta(string contaDestino, string bancoDestino, TiposDeConta tipoDeConta)
        {
            ContaDestino = contaDestino;
            BancoDestino = bancoDestino;
            TipoDeConta = tipoDeConta;
        }

        public string ContaDestino { get; private set; }
        public string BancoDestino { get; private set; }
        public TiposDeConta TipoDeConta { get; private set; }
    }
}
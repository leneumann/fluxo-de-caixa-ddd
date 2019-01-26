namespace Lancamentos
{
    public class Conta
    {
        public string ContaDestino { get; private set; }
        public string BancoDestino { get; private set; }
        public TiposDeConta TipoDeConta { get; private set; }
    }
}
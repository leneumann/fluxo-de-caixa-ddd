using System;
using System.Collections.Generic;
using System.Linq;
using FluxoDeCaixa.Domain.Livro;

namespace FluxoDeCaixa.Domain.Livro
{
    public class LivroCaixa
    {
        private IList<Lancamento> _entradas;
        private IList<Lancamento> _saidas;
        private IList<Lancamento> _encargos;

        public LivroCaixa(DateTime dataDoMovimento, decimal valorTotal, double posicaoDoDia)
        {
            DataDoMovimento = dataDoMovimento;
            ValorTotal = valorTotal;
            PosicaoDoDia = posicaoDoDia;
            _entradas = new List<Lancamento>();
            _saidas = new List<Lancamento>();
            _encargos = new List<Lancamento>();
        }

        public DateTime DataDoMovimento { get; private set; }
        public IReadOnlyCollection<Lancamento> Entradas { get { return _entradas.ToArray(); } }
        public IReadOnlyCollection<Lancamento> Saidas { get { return _saidas.ToArray(); } }
        public IReadOnlyCollection<Lancamento> Encargos { get { return _encargos.ToArray(); } }
        public decimal ValorTotal { get; private set; }
        public double PosicaoDoDia { get; private set; }

        public void AdicionarEntrada(Lancamento lancamento)
        {
            _entradas.Add(lancamento);
        }

        public void AdicionarSaida(Lancamento lancamento)
        {
            _entradas.Add(lancamento);
        }

        public void AdicionarEncargo(Lancamento lancamento)
        {
            _entradas.Add(lancamento);
        }
    }
}
using System;
using System.Collections.Generic;
using FluxoDeCaixa.Domain.ValueObjects;

namespace FluxoDeCaixa.Domain.Entities
{
    public class LivroCaixa
    {
        public DateTime DataDoLivro { get; set; }
        public List<Lancamento> Entradas { get; set; }
        public List<Lancamento> Saidas { get; set; }
        public List<Lancamento> Encargos { get; set; }
        public decimal ValorTotal { get; set; }
        public double PosicaoDoDia { get; set; }
    }
}
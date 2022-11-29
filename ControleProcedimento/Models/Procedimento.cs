using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleProcedimento.Models
{
    public abstract class Procedimento : ISolicitacao
    {
        public string Nome { get; set; }
        public int TempoMedioMinutos { get; set; }

        public Procedimento(string nome, int tempoMedioMinutos)
        {
            Nome = nome;
            TempoMedioMinutos = tempoMedioMinutos;
        }

        public override string ToString()
        {
            return $"{Nome}, {Custo()}";
        }

        public abstract double Custo();
    }
}
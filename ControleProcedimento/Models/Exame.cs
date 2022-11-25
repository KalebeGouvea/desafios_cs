using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleProcedimento.Models
{
    public class Exame : ISolicitacao
    {
        public string Nome { get; set; }
        public int TempoMedioMinutos { get; set; }

        public Exame(string nome, int tempoMedioMinutos)
        {
            Nome = nome;
            TempoMedioMinutos = tempoMedioMinutos;
        }

        public double Custo()
        {
            return TempoMedioMinutos * 20;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleProcedimento.Models
{
    public class Cirurgia : Procedimento
    {
        public Cirurgia(string nome, int tempoMedioMinutos) : base(nome, tempoMedioMinutos)
        {
            
        }

        public override double Custo()
        {
            return TempoMedioMinutos * 100;
        }
    }
}
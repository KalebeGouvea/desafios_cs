using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleProcedimento.Models
{
    public class Exame : Procedimento
    {
        public Exame(string nome, int tempoMedioMinutos) : base(nome, tempoMedioMinutos)
        {
            
        }

        public override double Custo()
        {
            return TempoMedioMinutos * 20;
        }
    }
}
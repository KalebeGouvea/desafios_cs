using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleProcedimento.Models
{
    public class Medicamento : ISolicitacao
    {
        public string PrincipioAtivo { get; set; }
        public double CustoMedicamento { get; set; }

        public Medicamento(string principioAtivo, double custo)
        {
            PrincipioAtivo = principioAtivo;
            CustoMedicamento = custo;
        }

        public double Custo()
        {
            return CustoMedicamento;
        }
    }
}
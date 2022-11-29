using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleProcedimento.Models
{
    public class Tratamento : ISolicitacao
    {
        List<ISolicitacao> Solicitacoes;
        public int Codigo { get; set; }
        private static int quantidadeTratamentos { get; set; }

        public Tratamento()
        {
            Solicitacoes = new List<ISolicitacao>();
            Codigo = quantidadeTratamentos;
            quantidadeTratamentos++;
        }

        public double Custo()
        {
            double valorCusto = 0;
            foreach(ISolicitacao solicitacao in Solicitacoes)
            {
                valorCusto += solicitacao.Custo();
            }
            return valorCusto;
        }

        public void adicionaSolicitacao(ISolicitacao solicitacao)
        {
            Solicitacoes.Add(solicitacao);
        }

        public void adicionaSolicitacao(List<ISolicitacao> listaSolicitacoes)
        {
            foreach (ISolicitacao solicitacao in listaSolicitacoes)
            {
                Solicitacoes.Add(solicitacao);
            }
        }

        public override string ToString()
        {
            //bit.ly/3BisEFh
            Solicitacoes.Sort((x, y) => y.Custo().CompareTo(x.Custo()));
            
            string result = $"Tratamento {Codigo} {{\n";
            foreach(Object solicitacao in Solicitacoes)
            {
                result += solicitacao + "\n";
            }
            return result + "}";
        }
    }
}
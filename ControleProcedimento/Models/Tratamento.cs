using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleProcedimento.Models
{
    public class Tratamento
    {
        List<Object> Solicitacoes;
        public int Codigo { get; set; }
        private static int quantidadeTratamentos { get; set; }

        public Tratamento()
        {
            Solicitacoes = new List<Object>();
            Codigo = quantidadeTratamentos;
            quantidadeTratamentos++;
        }

        public void adicionaSolicitacao(ISolicitacao solicitacao)
        {
            Solicitacoes.Add(solicitacao);
        }

        public void adicionaSolicitacao(List<Object> listaSolicitacoes)
        {
            foreach (Object solicitacao in listaSolicitacoes)
            {
                Solicitacoes.Add(solicitacao);
            }
        }

        public override string ToString()
        {
            string result = $"Tratamento {Codigo} {{\n";
            foreach(Object solicitacao in Solicitacoes)
            {
                result += solicitacao + "\n";
            }
            return result + "}";
        }
    }
}
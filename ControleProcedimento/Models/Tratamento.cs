using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleProcedimento.Models
{
    public class Tratamento
    {
        List<Object> Solicitacoes = new List<Object>();

        public void adicionaSolicitacao(ISolicitacao solicitacao)
        {
            Solicitacoes.Add(solicitacao);
        }

        public void adicionaSolicitacao(List<Object> listaSolicitacoes)
        {
            Solicitacoes.Add(listaSolicitacoes);
        }
    }
}
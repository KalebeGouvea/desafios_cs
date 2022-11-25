using System;
using ControleProcedimento.Models;

namespace ControleProcedimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISolicitacao sangue = new Exame("Exame de Sangue", 20);
            ISolicitacao biopsia = new Cirurgia("Biopsia", 30);
            Tratamento analiseAlergia = new Tratamento();
            analiseAlergia.adicionaSolicitacao(new List<ISolicitacao>(new []{ sangue, biopsia }));
            Console.WriteLine(analiseAlergia);
            ISolicitacao anestesia = new Medicamento("Anestesia", 1000);
            ISolicitacao septo = new Cirurgia("Correção de Septo", 120);
            Tratamento correcaoSepto = new Tratamento();
            correcaoSepto.adicionaSolicitacao(anestesia);
            correcaoSepto.adicionaSolicitacao(septo);
            Console.WriteLine(correcaoSepto);
            ISolicitacao cisto = new Cirurgia("Extração de Cisto", 60);
            Tratamento extracaoCisto = new Tratamento();
            extracaoCisto.adicionaSolicitacao(new List<ISolicitacao>(new []{ analiseAlergia, anestesia, cisto }));
            Console.WriteLine(extracaoCisto);
        }
    }
}
using System;

namespace ControleProcedimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solicitacao sangue = new Exame("Exame de Sangue", 20);
            Solicitacao biopsia = new Cirurgia("Biopsia", 30);
            Tratamento analiseAlergia = new Tratamento();
            analiseAlergia.adicionaSolicitacao(new List<Solicitacao>(new []{ sangue, biopsia }));
            Console.WriteLine(analiseAlergia);
            Solicitacao anestesia = new Medicamento("Anestesia", 1000);
            Solicitacao septo = new Cirurgia("Correção de Septo", 120);
            Tratamento correcaoSepto = new Tratamento();
            correcaoSepto.adicionaSolicitacao(anestesia);
            correcaoSepto.adicionaSolicitacao(septo);
            Console.WriteLine(correcaoSepto);
            Solicitacao cisto = new Cirurgia("Extração de Cisto", 60);
            Tratamento extracaoCisto = new Tratamento();
            extracaoCisto.adicionaSolicitacao(new List<Solicitacao>(new []{ analiseAlergia, anestesia, cisto }));
            Console.WriteLine(extracaoCisto);
        }
    }
}
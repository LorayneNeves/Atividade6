using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisarVriusCOVID_H1N1
{
    public class H1N1 : Virus
    {
        public string variacao;
        public string AnalisarVariacao()
        {
            Console.WriteLine("informe a variação: AAA ou N");
            variacao = Console.ReadLine();
            return variacao;
        }
        public override void ImprimirRecomendacoesTratamento()
        {
            if (variacao == "AAA")
            {
                Console.WriteLine("Ficar em casa por 5 dias.");
            }
            else
            {
                Console.WriteLine("Pode trabalhar e usar mascara.");
            }
        }
    }
}

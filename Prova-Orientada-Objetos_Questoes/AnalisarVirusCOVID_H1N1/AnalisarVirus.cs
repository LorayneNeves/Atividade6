using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisarVriusCOVID_H1N1
{
    public class AnalisarVirus
    {
        public void AnalisarVirus1()
        {
            int menu;
        menu:
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("opção 1 - COVID:");
            Console.WriteLine("opção 2 - H1N1:");
            menu = int.Parse(Console.ReadLine());
            Covid covid = new Covid();
            H1N1 h1N1 = new H1N1();

            switch (menu)
            {
                case 1:

                    Console.WriteLine("digite seu nome: ");
                    covid.nome = Console.ReadLine();
                    Console.WriteLine("Deixe uma observação: ");
                    covid.Observacao = Console.ReadLine();
                    Console.WriteLine("digite o tempo de quarentena:");
                    covid.TotalQuarentenaDias = int.Parse(Console.ReadLine());
                    covid.CalcularDataRetorno();
                    covid.ImprimirRecomendacoesTratamento();
                    goto menu;
                case 2:
                    Console.WriteLine("digite seu nome: ");
                    h1N1.nome = Console.ReadLine();
                    Console.WriteLine("Deixe uma observação: ");
                    h1N1.Observacao = Console.ReadLine();
                    h1N1.AnalisarVariacao();
                    h1N1.ImprimirRecomendacoesTratamento();
                    break;
                default:
                    break;
            }
        }
    }
}

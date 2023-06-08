using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Horista 
    {
        private double precoHora;
        private double horasTrabalhadas;
        public void ReceberDadosHorista()
        {
            Menuu menu = new Menuu();
            menu.ReceberDados();
            Console.WriteLine("Digite o valor da hora trabalhada: ");
            precoHora = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantas horas foram trabalhadas: ");
            horasTrabalhadas = double.Parse(Console.ReadLine());
        }
        public double ValorRecebido()
        {
            double vencimento = precoHora * horasTrabalhadas;
            Console.WriteLine(vencimento);
            return vencimento;
        }
    }
}

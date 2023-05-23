using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Poupanca : IConta
    {
        public double saldo { get; set; }
        public string numero { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public double CalcularSaldo()
        {
            return saldo;
        }
        public void Depositar(double valor)
        {            
            Console.WriteLine("digite o valor que deseja depositar na sua conta : ");
            valor = double.Parse(Console.ReadLine());
            saldo += valor;
            Console.WriteLine($"Voce possui R$ {saldo} reais na sua conta pupança"); 
        }        
        public void Sacar(double valor)
        {
            Console.WriteLine("digite o valor que deseja sacar na sua conta: ");
            valor = double.Parse(Console.ReadLine());
            saldo = saldo - valor;
            Console.WriteLine($"Voce possui R$ {saldo} reais na sua conta poupança ");
        }
        public double CalcularRendimento(double rendimento)
        {
            Console.WriteLine("Digite a porcentagem do rendimento: ");
            rendimento = double.Parse(Console.ReadLine());

            rendimento = (rendimento / 100) * saldo;
            saldo += rendimento;
            
            Console.WriteLine($"Com a movimentação atual o rendimento sera de: R$ {rendimento}");
            Console.WriteLine(saldo);
            return rendimento;
        }
    }
}

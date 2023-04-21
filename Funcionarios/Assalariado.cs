using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Assalariado
    {
        private double salario;
        
        public void ReceberDadosAssalariado()
        {
            Menuu menu = new Menuu();
            menu.ReceberDados();
            Console.WriteLine("Digite o salario: ");
            salario = double.Parse(Console.ReadLine());
        }
        public double ValorRecebido()
        {
            Console.WriteLine(salario);
            return salario;
        }
    }
}

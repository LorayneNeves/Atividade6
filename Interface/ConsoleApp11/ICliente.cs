using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    interface ICliente 
    {
        public string nome { get; set; }
        string cpf { get; set; }
        public void DadosCliente()
        {
            Console.WriteLine("Digite o CPF: ");
            cpf = Console.ReadLine();
            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();
        }
    }
}

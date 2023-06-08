using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Menuu
    {
        Horista horista = new Horista();
        Comissionado comissionado = new Comissionado();
        Assalariado assalaria = new Assalariado();
        public void ReceberDados()
        {
            Console.WriteLine("Digite nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sobrenome: ");
            string sobrenome = Console.ReadLine();
            Console.WriteLine("Digite cpf: ");
            string CPF = Console.ReadLine();
        }
        public void Menu()
        {
            menu:
            int menu;
            Console.WriteLine("Escolha uma opção :");
            Console.WriteLine("Opção 1 - Assalariado:");
            Console.WriteLine("Opção 2 - Comissionario:");
            Console.WriteLine("Opção 3 - Horista:");

            menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Opção Assalariado");
                    assalaria.ReceberDadosAssalariado();
                    assalaria.ValorRecebido();
                    Console.WriteLine();
                    goto menu;
                case 2:
                    Console.WriteLine("Opção Comissionario");
                    comissionado.ReceberDadosComissionado();
                    comissionado.ValorRecebido();
                    Console.WriteLine();
                    goto menu;
                case 3:
                    Console.WriteLine("Opção Horista");
                    horista.ReceberDadosHorista();
                    horista.ValorRecebido();
                    break;
                default:
                    break;
            }
        }
    }
}

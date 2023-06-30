using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Loja
    {
        public Campanha Campanha = new Campanha();
        public void Menu()
        {
        Menu:
            Console.WriteLine("Digite uma opção:");
            Console.WriteLine("1 - Cadastrar vendedor");
            Console.WriteLine("2 - Cadastrar premio");
            Console.WriteLine("3 - Cadastrar campanha");
            Console.WriteLine("4 - Pesquisar vendedor");
            Console.WriteLine("5 - Sair");
            int menu = int.Parse(Console.ReadLine());

            switch(menu)
            {
                case 1:
                    Campanha.CadastrarVendedor();
                    goto Menu;

                    case 2:
                    Campanha.CadastrarPremio();
                    goto Menu;

                    case 3:
                    Campanha.CadastrarCampanha();
                    goto Menu;

                    case 4:
                    Campanha.ProcurarVendedor();
                    goto Menu;
                        case 5:
                    break;
            }
        }
    }
}

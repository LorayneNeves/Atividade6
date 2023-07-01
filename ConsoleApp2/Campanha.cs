using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Campanha
    {
        public DateTime dataInicio { get; set; }
        public DateTime dataFinal { get; set; }
        public string nomeCampanha { get; set; }
        public Premio premio { get; set; }
        public List<Vendedor> vendedor = new List<Vendedor>();
        public void CadastrarVendedor()
        {
            Vendedor novoVendedor = new Vendedor();
            Console.WriteLine("Digite o nome do vendedor:");
            string nomeVendedor = Console.ReadLine();

            var ResultadoBusca = vendedor.Where(item => item.nome == nomeVendedor);
            if (!ResultadoBusca.Any())
            {
                novoVendedor.nome = nomeVendedor;

                Console.WriteLine("Digite o cpf do vendedor: ");
                string cpf = Console.ReadLine();
                novoVendedor.cpf = cpf;

                vendedor.Add(novoVendedor);
                
            }
            else { Console.WriteLine("Vendedor já existe"); }
            ImprimirListaVendedores();
        }
        public void ImprimirListaVendedores()
        {
            Console.WriteLine("Vendedores cadastrados: ");
            foreach (Vendedor item in vendedor)
            {
                Console.WriteLine("nome : " + item.nome);
                Console.WriteLine("cpf : " + item.cpf);

            }
            Console.WriteLine();
        }
        public void ProcurarVendedor()
        {
            string cpfVendedor;
            Console.WriteLine("Digite o cpf do vendedor para pesquisar: ");
            cpfVendedor = Console.ReadLine();
            var vendedor1 = vendedor.FirstOrDefault(vendedor1 => vendedor1.nome == cpfVendedor);

            foreach (Vendedor item in vendedor)
            {

                if (item.cpf == cpfVendedor)
                {
                    Console.WriteLine($"Vendedor '{item.nome}' encontrado. Dados do vendedor:");
                    Console.WriteLine($"CPF : {item.cpf}");
                    Console.WriteLine($"Nome : {item.nome}");
                }
            }
            Console.WriteLine();
        }
        public void CadastrarPremio()
        {
            premio = new Premio();
            Console.WriteLine("Digite a descrição do premio:");
            premio.descricao = Console.ReadLine();
            Console.WriteLine("Digite codigo do premio:");
            premio.codigo = int.Parse(Console.ReadLine());

            ImprimirPremio();
        }
        public void ImprimirPremio()
        {
            Console.WriteLine($"Premio cadastrado: {premio.codigo} , {premio.descricao}");
        }
        public void CadastrarCampanha()
        {
            Console.WriteLine("digite nome da campanha:");
            nomeCampanha = Console.ReadLine();
            Console.WriteLine("Digite a data inicial da campanha: ");
            dataInicio = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite a data final da campanha: ");
            dataFinal = DateTime.Parse(Console.ReadLine());
            ImprimirDadosCampanha();
        }     
        public void ImprimirDadosCampanha() {
            Console.Clear();    
            Console.WriteLine("nome da campanha: "+nomeCampanha);
            Console.WriteLine("data inicial: "+ dataInicio);
            Console.WriteLine("data final: " + dataFinal);
            
            ImprimirListaVendedores();
            Console.WriteLine("premio da campanha: ");
            ImprimirPremio();
        }
    } 
}

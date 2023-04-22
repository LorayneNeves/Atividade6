using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios_Dependentes
{
    public class Controle
    {
        List<Dependentes> ListaDependentes = new List<Dependentes>();                
        Funcionario funcionario = new Funcionario();

        public void AdicionarDependente()
        {
            Console.WriteLine("Digite nome do Funcionario:");
            funcionario.nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de dependentes para adicionar na lista: ");
            int QuantDependentes = int.Parse(Console.ReadLine());

            for (int i = 0; i < QuantDependentes; i++)
            {
                Dependentes dependentes = new Dependentes();

                Console.WriteLine("Digite o nome do dependente:");
                string nomeNovoDependente = Console.ReadLine();

                var ResultadoBusca = ListaDependentes.Where(item => item.nome == nomeNovoDependente);

                if (!ResultadoBusca.Any())
                {
                    dependentes.nome = nomeNovoDependente;

                    Console.WriteLine("Digite a idade: ");
                    dependentes.idade = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a familiaridade ");
                    dependentes.familiaridade = Console.ReadLine();
                    ListaDependentes.Add(dependentes);
                    ImprimirListaDependentes(ListaDependentes);

                }
                else
                {
                    Console.WriteLine("Dependente já existente, operação não realizada");
                }
                void ImprimirListaDependentes(List<Dependentes> lista)
                {
                    Console.WriteLine($"Lista de Dependentes do funcionario: {funcionario.nome} ");
                    foreach (var item in lista)
                    {
                        Console.WriteLine($"Nome do dependente : {item.nome} | idade do dependente : {item.idade} | familiaridade : {item.familiaridade} ");
                    }
                }
            }
            Console.Read();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Estado
    {
        List<Cidade> ListaCidades = new List<Cidade>();

        public void CadastrarCidade()
        {
            Console.WriteLine("digite a quantidade cidades para adicionar a lista");

            int quantidadecidade = int.Parse(Console.ReadLine());


            for (int i = 0; i < quantidadecidade; i++)
            {
                Cidade cidade = new Cidade();

                Console.WriteLine("Digite o nome da cidade:");
                string nomeNovaCidade = Console.ReadLine();

                var ResultadoBusca = ListaCidades.Where(item => item.nome == nomeNovaCidade);

                if (!ResultadoBusca.Any())
                {
                    cidade.nome = nomeNovaCidade;
                    Console.WriteLine("Digite a quantidade de populaçaõ da cidade: ");
                    cidade.populacao = int.Parse(Console.ReadLine());
                    ListaCidades.Add(cidade);
                    
                }
                else
                {
                    Console.WriteLine("Cidade já existente, operação não realizada");
                }

            }
        }
        public void ImprimirCidade()
        {
            Console.WriteLine("Lista de cidades");
            foreach(var item in ListaCidades)
            {
                Console.WriteLine($"Nome da cidade : {item.nome} | população da cidade : {item.populacao}");
            }
        }
        public void LocalizarCidadeMaiorPopulacao()
        {
            int maiorPopulacao=0;
            foreach(var item in ListaCidades)
            {
                if(item.populacao > maiorPopulacao)
                {
                    maiorPopulacao = item.populacao;                
                    Console.WriteLine($"A cidade {item.nome} tem maior população: {maiorPopulacao}");
                    
                }
            }
            
        }
    }
}

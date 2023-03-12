using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaAlunos;

List<Lista> Aluno = new List<Lista>();

Console.WriteLine("Digite a quantidade de alunos para adicionar na lista: ");
int QuantAlunos = int.Parse(Console.ReadLine());


for(int i = 0;  i < QuantAlunos; i++)
{
    Lista novaLista = new Lista();

    Console.WriteLine("Digite o nome do aluno:");
    string nomeNovaLista = Console.ReadLine();

    var ResultadoBusca = Aluno.Where(item => item.nomeAluno == nomeNovaLista);

    if (!ResultadoBusca.Any())
    {
        novaLista.nomeAluno = nomeNovaLista;
    
        Console.WriteLine("Digite o RA do aluno: ");
        string RAaluno = Console.ReadLine();
        novaLista.RAaluno = RAaluno;
    
        Console.WriteLine("Digite a nota do trabalho: ");
        decimal notaTrabalho = decimal.Parse(Console.ReadLine());
        novaLista.notaTrabalho = notaTrabalho;
    
        Console.WriteLine("Digite a nota prova: ");
        decimal notaProva = decimal.Parse(Console.ReadLine());
        novaLista.notaProva = notaProva;
    
    
        decimal notaFinal = notaProva + notaTrabalho;
        novaLista.notaFinal = notaFinal;
        Console.WriteLine(notaFinal);
    
        Aluno.Add(novaLista);
        ImprimirTarefas(Aluno);
    }
    else
    {
        Console.WriteLine("Aluno já existente, operação não realizada");
    }
    void ImprimirTarefas(List<Lista> lista)
    {
        Console.WriteLine("Lista de Alunos: ");

        foreach (var item in lista)
        {
            Console.WriteLine($"Nome do aluno = {item.nomeAluno} | RA do aluno {item.RAaluno} | nota trabalho = {item.notaTrabalho} | nota Prova = {item.notaProva} | nota total do bimestre = {item.notaFinal}");
        }
    }
}
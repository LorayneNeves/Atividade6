using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    public class GerenciaDados
    {
        public void MenuAluno()
        {
            List<Alunos> Aluno = new List<Alunos>();
            List<Atividades> Atividades = new List<Atividades>();
        menu1:
            Console.WriteLine("1 - add aluno");
            Console.WriteLine("2 - listar aluno");
            Console.WriteLine("3 - pesquisar aluno");
            Console.WriteLine("4 - remover aluno");
            Console.WriteLine("5 - relatorio de atividades dos alunos cadastrados");
            Console.WriteLine("6 - Relatorio de atividades de todos os periodos");
            int menu1 = int.Parse(Console.ReadLine());
            switch (menu1)
            {
                case 1:
                    Alunos aluno = new Alunos();
                    Atividades atividades = new Atividades();
                    TCC tcc = new TCC();

                    Console.WriteLine("Digite o nome do aluno:");
                    string nomealuno = Console.ReadLine();
                    var ResultadoBusca = Aluno.Where(item => item.Nome == nomealuno);

                    if (!ResultadoBusca.Any())
                    {
                        aluno.Nome = nomealuno;

                        Console.WriteLine("Digite RA: ");
                        string RAaluno = Console.ReadLine();
                        aluno.Id = RAaluno;

                        Console.WriteLine("Digite nome do curso: ");
                        string curso = Console.ReadLine();
                        aluno.curso = curso;

                        Console.WriteLine("Digite o periodo: ");
                        int periodo = int.Parse(Console.ReadLine());
                        aluno.Periodo = periodo;

                        Console.WriteLine("Digite cpf: ");
                        string CPF = Console.ReadLine();
                        aluno.cpf = CPF;

                        Aluno.Add(aluno);

                        Console.WriteLine("Adicionar atividade? s/n ");
                        char opcao = char.Parse(Console.ReadLine());

                        if (opcao == 's')
                        {
                            Console.WriteLine("Digite nome da atividade: ");
                            atividades.nomeAtividade = Console.ReadLine();

                            Console.WriteLine("Digite nota da atividade: ");
                            atividades.nota = double.Parse(Console.ReadLine());

                            Console.WriteLine("Digite data de inicio: ");
                            atividades.dataInicio = DateTime.Parse(Console.ReadLine());

                            aluno.Atividades = atividades;

                            Console.WriteLine("Adicionar TCC? s/n ");
                            char opcao1 = char.Parse(Console.ReadLine());

                            if (opcao1 == 's')
                            {
                                Console.WriteLine("Titulo");
                                tcc.titulo = Console.ReadLine();
                                Console.WriteLine("data");
                                tcc.data = DateTime.Parse(Console.ReadLine());
                                Console.WriteLine("digite nome do orientador:");
                                tcc.orientador = Console.ReadLine();
                                //Console.WriteLine("tempo gasto");
                                //tcc.timer = TimeOnly.Parse(Console.ReadLine());
                                aluno.Atividades.tcc = tcc;
                            }
                            else { goto menu1; }
                        }
                        else { goto menu1; }
                        Imprimir();
                    }
                    else
                    {
                        Console.WriteLine("Aluno já existente, operação não realizada");
                    }
                    void Imprimir()
                    {
                        Console.WriteLine($"Existem {Aluno.Count} alunos na sua universidade");
                        foreach (Alunos item in Aluno)
                        {
                            if (item.Atividades == null)
                            {
                                Console.WriteLine($"nome: {item.Nome} RA {item.Id} | CPF: {item.cpf} | Curso: {item.curso} | Periodo: {item.Periodo}");
                            }
                            else if (item.Atividades.tcc == null)
                            {
                                Console.WriteLine($"nome: {item.Nome} RA {item.Id} | CPF: {item.cpf} | Curso: {item.curso} | Periodo: {item.Periodo} | atividade: {item.Atividades.nomeAtividade} | nota: {item.Atividades.nota} | data: {item.Atividades.dataInicio} ");
                            }
                            else
                            {
                                Console.WriteLine($"nome: {item.Nome} RA {item.Id} | CPF: {item.cpf} | Curso: {item.curso} | Periodo: {item.Periodo} | atividade: {item.Atividades.nomeAtividade} | nota: {item.Atividades.nota} | data: {item.Atividades.dataInicio} | tcc: {item.Atividades.tcc.titulo} | orientador {item.Atividades.tcc.orientador}");
                            }
                        }
                        Console.WriteLine();
                    }                  
                    void Relatorio()
                    {
                        foreach (Alunos item in Aluno)
                        {
                            if (item.Atividades.tcc == null)
                            {
                                Console.WriteLine($" Curso: {item.curso} | atividade: {item.Atividades.nomeAtividade} | nota: {item.Atividades.nota} | data: {item.Atividades.dataInicio} ");
                            }
                            else if(item.Atividades == null)
                            {
                                Console.WriteLine("Sem atividades para listar");
                            }
                            else
                            {
                                Console.WriteLine($" Curso: {item.curso} | atividade: {item.Atividades.nomeAtividade} | nota: {item.Atividades.nota} | data: {item.Atividades.dataInicio} | tcc: {item.Atividades.tcc.titulo} | orientador {item.Atividades.tcc.orientador} | data: {item.Atividades.tcc.data} tempo gasto:{item.Atividades.tcc.timer}");
                            }
                        }
                    }
                    void PesquisarPorAluno()
                    {
                        string nomeAluno;
                        Console.WriteLine("Digite o nome do aluno para pesquisar: ");
                        nomeAluno = Console.ReadLine();
                        var aluno = Aluno.FirstOrDefault(aluno => aluno.Nome == nomeAluno);

                        foreach (Alunos item in Aluno)
                        {
                            if (item.Nome == nomeAluno)
                            {
                                Console.WriteLine($"Aluno '{item.Nome}' encontrado. Dados do aluno:");
                                Console.WriteLine($"Nome : {item.curso}");
                                Console.WriteLine($"RA: {item.Id}");
                                Console.WriteLine($"CPF: {item.cpf}");
                                Console.WriteLine($"Periodo: {item.Periodo}");
                                Console.WriteLine($"atividade: {item.Atividades.nomeAtividade}");
                                Console.WriteLine($"atividade: {item.Atividades.nota}");
                                Console.WriteLine($"atividade: {item.Atividades.dataInicio}");
                            }
                        }
                        Console.WriteLine();
                    }
                    void Remover()
                    {
                        string ra;
                        Console.WriteLine("Qual aluno deseja remover, informar por RA : ");
                        ra = Console.ReadLine();
                        var aluno = Aluno.FirstOrDefault(aluno => aluno.Id == ra);
                        if (ra != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Aluno {aluno.Nome}, RA: {ra} foi removido !");
                            Aluno.Remove(aluno);
                            Console.WriteLine();

                            foreach (var item in Aluno)
                            {
                                Console.WriteLine(aluno.Nome);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Aluno {aluno.Id} , {aluno.Nome} nao encontrado!");
                        }
                    }
                    goto menu1;
                case 2:
                    Imprimir();
                    goto menu1;
                case 3:
                    PesquisarPorAluno();
                    goto menu1;
                case 4:
                    Remover();
                    goto menu1;
                case 5:
                    Relatorio();
                    goto menu1;
                case 6:
                    RelatorioAtividades_API a = new RelatorioAtividades_API();
                    _ = a.Atividades();
                    goto menu1;
                    case 7:
                    break;
            }
        }
        public void MenuProfessor()
        {
            List<Professor> Professor = new List<Professor>();
        menu2:
            Console.WriteLine("1 - add professor");
            Console.WriteLine("2 - listar professor");
            Console.WriteLine("3 - remover professor");
            Console.WriteLine("4 - sair");
            int menu2 = int.Parse(Console.ReadLine());
            switch (menu2)
            {
                case 1:
                    Professor professor = new Professor();
                    TCC tcc = new TCC();
                    Endereco endereco = new Endereco();
                    Console.WriteLine("Digite o nome do professor:");
                    string nome = Console.ReadLine();
                    var ResultadoBusca = Professor.Where(item => item.Nome == nome);

                    if (!ResultadoBusca.Any())
                    {
                        Console.WriteLine("Digite nome do professor: ");
                        professor.Nome = Console.ReadLine();

                        Console.WriteLine("Digite RA: ");
                        professor.Id = Console.ReadLine();

                        Console.WriteLine("Digite nome do curso: ");
                        professor.curso = Console.ReadLine();

                        Console.WriteLine("Digite o periodo: ");
                        professor.Periodo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite cpf: ");
                        professor.cpf = Console.ReadLine();

                        Console.WriteLine("salario:");
                        professor.Salario = double.Parse(Console.ReadLine());


                        Console.WriteLine("Digite endereço: ");
                        Console.Write("cep: ");
                        endereco.Cep = Console.ReadLine();
                        Console.Write("numero: ");
                        endereco.numero = int.Parse(Console.ReadLine());
                        Console.Write("rua: ");
                        endereco.rua = Console.ReadLine();
                        professor.Endereco = endereco;
                        Professor.Add(professor);

                        Console.WriteLine("Adicionar TCC? s/n ");
                        char opcao1 = char.Parse(Console.ReadLine());

                        if (opcao1 == 's')
                        {
                            Console.WriteLine("Titulo");
                            tcc.titulo = Console.ReadLine();

                            Console.WriteLine("data");
                            tcc.data = DateTime.Parse(Console.ReadLine());

                            Console.WriteLine("Digite seu nome: ");
                            tcc.orientador = Console.ReadLine();
                            //Console.WriteLine("tempo");
                            //tcc.timer = TimeOnly.Parse(Console.ReadLine());
                            professor.tcc = tcc;
                        }
                        else { goto menu2; }
                        Imprimir();
                    }
                    else
                    {
                        Console.WriteLine("Professor já existente, operação não realizada");
                    }
                    void Imprimir()
                    {            
                        foreach (Professor item in Professor)
                        {
                            if (item.tcc == null)
                            {
                                Console.WriteLine($"nome: {item.Nome} RA {item.Id} | CPF: {item.cpf} | Curso: {item.curso} | Periodo: {item.Periodo} | Endereço: {item.Endereco} | salario: {item.Salario}");
                            }
                            else
                            {
                                Console.WriteLine($"nome: {item.Nome} RA {item.Id} | CPF: {item.cpf} | Curso: {item.curso} | Periodo: {item.Periodo} | Endereço: {item.Endereco.Cep} | salario: {item.Salario} | tcc: {item.tcc.titulo}");
                            }
                        }
                        Console.WriteLine();
                    }
                    void Remover()
                    {
                        string id;
                        Console.WriteLine("Qual professor deseja remover, informar por RA : ");
                        id = Console.ReadLine();
                        var professor = Professor.FirstOrDefault(professor => professor.Id == id);
                        if (id != null)
                        {
                            Console.WriteLine();
                            Console.WriteLine($"Professor {professor.Nome}, RA: {id} foi removido !");
                            Professor.Remove(professor);
                            Console.WriteLine();

                            foreach (var item in Professor)
                            {
                                Console.WriteLine(professor.Nome);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Professor {professor.Id} nao encontrado!");
                        }
                    }
                    goto menu2;
                case 2:
                    Imprimir();
                    goto menu2;
                case 3:
                    Remover();
                    goto menu2;
                case 4:
                    break;
            }
        }
    }
}
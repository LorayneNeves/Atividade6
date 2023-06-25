using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    public class MenuPrincipal : GerenciaDados
    {

        public void MenuGerencia()
        {
            Alunos aluno = new Alunos();
            GerenciaDados gerencia = new GerenciaDados();
            ControleDeNotas controleDeNotas = new ControleDeNotas();
            RelatorioAtividades_API relatorioAtividades = new RelatorioAtividades_API();
            int opcao;
        menu:
            Console.WriteLine("Escolha uma opção para continuar...");
            Console.WriteLine("Opção 1: adicionar Aluno");
            Console.WriteLine("Opção 2: adicionar PRofessor");
            Console.WriteLine("Opção 3: listar atividades alunos");
            Console.WriteLine("Opção 4: Central de notas alunos");
            Console.WriteLine("Opção 5: sair");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    gerencia.MenuAluno();
                    goto menu;
                case 2:
                    gerencia.MenuProfessor();
                    goto menu;
                case 3:
                    _ = relatorioAtividades.Atividades();
                    goto menu;
                case 4:
                    controleDeNotas.SolicitarNota();
                    controleDeNotas.SolicitarNotaProva();
                    controleDeNotas.ImprimirCalculoNotas(0);
                    controleDeNotas.EnviarImpressao();
                    Console.WriteLine();                  
                    goto menu;
                    case 5:
                    break;
                default:
                    break;
            }
        }   
    }
}


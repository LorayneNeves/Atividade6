using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    public abstract class GerenciaNotas
    {
        Trabalhos documento = new Trabalhos();
        Prova prova = new Prova();
        public void EnviarImpressao()
        {
            ControleDeNotas impressora = new ControleDeNotas(documento);
            ControleDeNotas relatorio = new ControleDeNotas(prova);
            impressora.SomaTrabalhos();
            relatorio.Calculo();
        }
        public void SolicitarNota()
        {
            Console.Write("Digite nota trabalho 1: ");
            documento.notaTrabalho1 = double.Parse(Console.ReadLine());
            Console.Write("Digite nota trabalho 2: ");
            documento.notaTrabalho2 = double.Parse(Console.ReadLine());
        }
        public void SolicitarNotaProva()
        {
            Console.Write("Digite quantidade de quatoes: ");
            prova.quantidadeQuestoes =int.Parse(Console.ReadLine());
            Console.Write("Digite nota prova: ");
            prova.valorNota =double.Parse(Console.ReadLine());      
        }
        public double ImprimirCalculoNotas(double valor)
        {
            valor = prova.valorNota + documento.notaTrabalho1 + documento.notaTrabalho2;
            Console.WriteLine("Valor total da somatoria de trabalhos e prova: ");
            Console.WriteLine(valor);
            return valor;          
        }
        public abstract void SomaTrabalhos();
        public abstract void Calculo();
    }
}

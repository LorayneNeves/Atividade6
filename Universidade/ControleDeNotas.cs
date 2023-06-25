using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    public class ControleDeNotas : GerenciaNotas
    {
        Trabalhos documento;
        Prova Prova;
        public ControleDeNotas() { }
        public ControleDeNotas(Trabalhos documento1)
        {
            documento = documento1;
        }
        public ControleDeNotas(Prova prova)
        {
            Prova = prova;
        }
        public override void SomaTrabalhos()
        {
           double valor = documento.notaTrabalho1 +  documento.notaTrabalho2;
           Console.WriteLine("somatoria dos trabalhos:"+valor);
            
        }
        public override void Calculo()
        {
            double valor = Prova.valorNota / Prova.quantidadeQuestoes;
            Console.WriteLine("media de acertos questao "+valor);
        }
     }
}

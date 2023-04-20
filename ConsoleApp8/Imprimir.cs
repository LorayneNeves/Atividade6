using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeImpressoes
{
    public class Imprimir 
    {
        Documento documento = new Documento();
        public void EnviarImpressao()
        {
          Impressora impressora = new Impressora(documento);
          impressora.CopiasDoTexto();
        }
        public void SolicitarTexto()
        {
            Console.Write("Digite o texto a ser impresso: ");
            documento.Texto = Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ControleDeImpressoes
{
    public class Impressora
    {
        public int QuantidadeCopia { get; set; }
        Documento documento;
        public Impressora(Documento documento1)
        {
            documento = documento1;
            Console.WriteLine(documento1.Texto);
        }
        public void CopiasDoTexto()
        {
            Console.Write("Digite a quantidade de copias: ");
            QuantidadeCopia = int.Parse(Console.ReadLine());
            for (int i = 0; i < QuantidadeCopia; i++)
            {
                Console.WriteLine(documento.Texto);
            }
        }
    }
}
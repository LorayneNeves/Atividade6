using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace Artigo_arquivoTexto
{
    class ManipularArquivo
    {
        public string conteudo;
        public string path;

        static void Main(string[] args)
        {
            EnderecoNomeArquivo();

            SalvarDadoseArquivo();
        }
        private static bool SalvarDadoseArquivo()
        {
            StreamWriter sw = new StreamWriter("C:\\temp\\meutxt.txt", true, Encoding.ASCII);

            return true;
        }
        private static string EnderecoNomeArquivo()
        {
            string path = @"C:\\temp\\meutxt.txt";

            if (!File.Exists(path))
            {
                using (var sw = File.CreateText(path))
                {
                    Console.WriteLine("Digite o conteudo para o arquivo txt: ");

                    string conteudo = Console.ReadLine();

                    sw.WriteLine(conteudo);
                    sw.Close();
                }
            }
            else
            {
                using (var sw = File.CreateText($"{path}"))
                {
                    Console.WriteLine("Digite o conteudo para o arquivo txt: ");
                    string conteudo = Console.ReadLine();
                    sw.WriteLine(conteudo);
                    sw.Close();
                }
            }
            return path;
        }
    }
}
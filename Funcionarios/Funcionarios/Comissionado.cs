using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Comissionado
    {
        private double totalVenda;
        private double taxaComissao;
        public void ReceberDadosComissionado()
        {
            Menuu menu = new Menuu();
            menu.ReceberDados();
            Console.WriteLine("Digite o total vendido: ");
            totalVenda = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite total da taxa da comissao: ");
            taxaComissao = double.Parse(Console.ReadLine());
        }

        public double ValorRecebido()
        {
            double vencimento = totalVenda * taxaComissao/100;
            Console.WriteLine(vencimento);
            return vencimento;
        }
    }
}

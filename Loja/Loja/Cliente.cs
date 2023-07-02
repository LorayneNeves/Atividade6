using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public class Cliente
    {
        // classe cliente de uma Loja

        public string nome;
        public int quantidade;
        public decimal valorProduto;
        public string produto;
        decimal valorTotal;

        //Metodo para calcular o valor total da compra de um produto em especifico
        public void ValorDaCompra()
        {
            valorTotal = valorProduto * quantidade;
        }

        //metodo pra imprimir os dados da compra/cliente
        public void ImprimirDadosDoCliente()
        {
            Console.WriteLine($"Produto comprado: {produto}." + "\n" + ($"Valor total da compra do(a) cliente = {valorTotal} reais "));
        }
    }   
}

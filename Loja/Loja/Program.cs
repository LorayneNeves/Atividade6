using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja;

Cliente cliente = new Cliente();

Console.WriteLine("digite o nome do cliente: ");
cliente.nome = Console.ReadLine();

Console.WriteLine("Digite qual produto: ");
cliente.produto = Console.ReadLine();

Console.WriteLine("digite a quantidade de produtos que ira comprar: ");
cliente.quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("digite o valor do produto: ");
cliente.valorProduto = decimal.Parse(Console.ReadLine());

cliente.ValorDaCompra();
cliente.ImprimirDadosDoCliente();

//Programa recebe os dados de um cliente para um certo produto em especifico, o usuario entra com o valor do produto e
//quantidade de itens e o programa retorna o valor total da compra

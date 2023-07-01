using System;
using ConsoleApp11;
ICliente cliente;
Console.WriteLine("Digite 1 Corrente | 2 Poupança | 3 Salario ");
int menu = int.Parse(Console.ReadLine());
switch (menu)
{
    case 1:
        Corrente corrente = new Corrente();
        cliente = new Corrente();
        cliente.DadosCliente();

    opcaoCorrente:
        Console.WriteLine("Digite 1 Para depositar | 2 Para sacar | 3 Para ver o valor da tarifa cobrada no mes ");
        int opcaoCorrente = int.Parse(Console.ReadLine());
        switch (opcaoCorrente)
        {
            case 1:
                corrente.Depositar(corrente.saldo);
            goto opcaoCorrente;
            case 2:
                corrente.Sacar(corrente.saldo);
                goto opcaoCorrente;
            case 3:
                corrente.CalcularTarifa();
            break;
        }
    break;
    case 2:
        Poupanca poupanca = new Poupanca();
        cliente = new Poupanca();
        cliente.DadosCliente();

    opcaoPoupanca:
        Console.WriteLine("Digite 1 Para depositar | 2 Para sacar | 3 Para ver rendimento | 4 Para sair ");
        int opcaoPoupanca = int.Parse(Console.ReadLine());
        switch (opcaoPoupanca) 
        { 
            case 1:
                poupanca.Depositar(poupanca.saldo);
            goto opcaoPoupanca; 
            case 2:
                poupanca.Sacar(poupanca.saldo);
            goto opcaoPoupanca; 
            case 3:
                poupanca.CalcularRendimento(0);
            goto opcaoPoupanca;
            case 4:break;
        }       
    break; 
    case 3:
        Salario salario = new Salario();
        cliente = new Salario();
        cliente.DadosCliente();

    opcaoSalario:
        Console.WriteLine("Digite 1 para depositar | 2 para sacar: | 3 para sair");
        int opcaoSalario = int.Parse(Console.ReadLine());
        switch(opcaoSalario)
        {
            case 1:
                salario.Depositar(salario.saldo);
            goto opcaoSalario;
            case 2:
                salario.Sacar(salario.saldo);
            goto opcaoSalario;
            case 3:break;
        }
    break;

default: Console.ReadKey();
break;
}



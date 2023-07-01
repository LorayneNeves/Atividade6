using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    interface IConta : ICliente
    {
        double saldo { get; set; }
        string numero { get; set; }
        double CalcularSaldo();
        void Sacar(double valor);
        void Depositar(double valor);

    }
}

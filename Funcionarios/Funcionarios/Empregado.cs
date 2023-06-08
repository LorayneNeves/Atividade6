using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    abstract class Empregado 
    {
        public string nome { get; protected set; }
        public string sobrenome { get; protected set; }
        public string CPF { get; protected set; }
        public int valor;
        public abstract double ValorRecebido();



    }
}

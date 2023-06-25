using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    interface IFuncionario : IPessoa
    {
        public double Salario { protected get; set; }
    }
}

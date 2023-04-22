using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios_Dependentes
{
    public class Dependentes
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public string familiaridade { get; set; }
        public Funcionario funcionario { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    public class Professor : IFuncionario
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string curso { get; set; }
        public int Periodo { get; set; }
        public string cpf { get; set; }
        public double Salario { get; set; } 
        public Endereco Endereco { get; set; }
        public TCC tcc { get; set; }      
    }
}

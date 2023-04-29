using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisarVriusCOVID_H1N1
{
    public abstract class Virus
    {
        public string nome { get; set; }
        public string Observacao { get; set; }

        public abstract void ImprimirRecomendacoesTratamento();



    }
}

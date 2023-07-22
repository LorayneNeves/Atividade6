using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    public class Atividades : Alunos
    {
        public string nomeAtividade { get; set; }
        public DateTime dataInicio { get; set; }
        public double nota { get; set; }
        public TCC tcc;

    }
}

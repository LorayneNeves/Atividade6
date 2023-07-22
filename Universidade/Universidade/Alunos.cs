using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidade
{
    public class Alunos : IPessoa
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string curso { get; set; }
        public int Periodo { get; set; }
        public string cpf { get; set; }
        public Atividades Atividades { get; set; }
        Endereco IPessoa.Endereco { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

}

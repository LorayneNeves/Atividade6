using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listaTarefas
{
    public class tarefas
    {
        public string nome;
        public int esforco; // em horas
        public bool finalizado = false;


        public void gerarTarefa(string Nome, int Esforco)
        {
            nome = Nome;
            esforco = Esforco;
        }

        public bool tarefafeita(bool finalizado)
        {

            bool final = finalizado;



            return finalizado;
        }
    }
}

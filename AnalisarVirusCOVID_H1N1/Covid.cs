using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisarVriusCOVID_H1N1
{
    public class Covid : Virus
    {
        public int TotalQuarentenaDias { get; set; }
        public DateTime data;


        public DateTime CalcularDataRetorno()
        {
            data = DateTime.Today.AddDays(TotalQuarentenaDias);
            return data;
        }
        public override void ImprimirRecomendacoesTratamento()
        {
            Console.WriteLine("Voce devera retornar em:" + data);
        }
    }
}

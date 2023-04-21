using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormaGeometrica
{
    public class Circunferencia : Forma
    {
        public double Raio { get; set; }
        public override void CalcularArea()
        {
            Console.Write("Digite o valor do raio: ");
            Raio = double.Parse(Console.ReadLine());
            double area = Math.PI * Raio * Raio;
            Console.WriteLine("Area:" +area);
        }
        public override void CalcularPerimentro()
        {
            double Perimetro = 2 * Math.PI * Raio;
            Console.WriteLine("Perimetro: "+Perimetro);
        }
    }
}

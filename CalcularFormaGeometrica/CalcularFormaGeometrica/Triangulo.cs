using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormaGeometrica
{
    public class Triangulo : Forma
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }
        public override void CalcularArea()
        {
            Console.Write("Digite os valores dos lados A,B,C do triangulo: ");
            LadoA = int.Parse(Console.ReadLine());
            LadoB = int.Parse(Console.ReadLine());
            LadoC = int.Parse(Console.ReadLine());

            double area = (LadoA * LadoB) / 2;
            Console.WriteLine("Area: "+ area);
        }
        public override void CalcularPerimentro()
        {
            double perimetro = LadoA + LadoB + LadoC;
            Console.WriteLine("Perimetro: "+perimetro);
        }
    }
}
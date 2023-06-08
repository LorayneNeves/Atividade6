using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormaGeometrica
{
    public class Quadrado : Forma
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }

        public override void CalcularArea()
        {
            Console.Write("Digite os valores dos lados A,B do quadrado: ");
            LadoA = double.Parse(Console.ReadLine());
            LadoB = double.Parse(Console.ReadLine());
            double area = LadoA * LadoB;
            Console.WriteLine("Area: "+area);
        }
        public override void CalcularPerimentro()
        {
            double perimetro = LadoA * 4;
            Console.WriteLine("Perimetro: "+perimetro);
        }
    }
}
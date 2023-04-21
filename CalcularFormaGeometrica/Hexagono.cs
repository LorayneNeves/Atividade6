using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormaGeometrica
{
    public class Hexagono : Forma
    {
        public double Lado { get; set; }
        public override void CalcularArea()
        {
            Console.Write("Digite o valor do lado do triangulo: ");
            Lado = int.Parse(Console.ReadLine());

            double area = 6 * (Math.Sqrt(3) * (Lado * Lado)) / 4;
            Console.WriteLine("Area: " + area);
        }
        public override void CalcularPerimentro()
        {
            double perimetro = Lado * 6 ;
            Console.WriteLine("Perimetro: " + perimetro);
        }
    }
}
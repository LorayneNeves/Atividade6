using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormaGeometrica
{
    public class GerarForma
    {
        public void SolicitarForma()
        {
            int menu;
        menu:
            Console.WriteLine("Escolha uma opção para continuar...");
            Console.WriteLine("Opção 1: Forma circulo");
            Console.WriteLine("Opção 2: Forma Quadrado");
            Console.WriteLine("Opção 3: Forma Triangulo");
            Console.WriteLine("Opção 4: Forma Hexagono");
            menu = int.Parse(Console.ReadLine());

            Circunferencia circunferencia = new Circunferencia();
            Quadrado quadrado = new Quadrado();
            Triangulo triangulo = new Triangulo();
            Hexagono hexagono = new Hexagono();

            switch (menu)
            {
                case 1:
                    circunferencia.CalcularArea();
                    circunferencia.CalcularPerimentro();
                    Console.WriteLine();
                    goto menu;
                case 2:
                    quadrado.CalcularArea();
                    quadrado.CalcularPerimentro();
                    Console.WriteLine();
                    goto menu;
                case 3:
                    triangulo.CalcularArea();
                    triangulo.CalcularPerimentro();
                    Console.WriteLine();
                    goto menu;
                case 4:
                    hexagono.CalcularArea();
                    hexagono.CalcularPerimentro();
                    break;
                default:
                    break;
            }

        }
    }
}
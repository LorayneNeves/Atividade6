using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularFormaGeometrica
{
    public class Forma
    {
        public double Area { get; set; }
        public int Perimentro { get; set; }

        public virtual void CalcularArea()
        {

        }
        public virtual void CalcularPerimentro()
        {

        }
    }
}
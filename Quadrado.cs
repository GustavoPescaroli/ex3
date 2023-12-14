using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Quadrado
    {
        public double diagonal;

        public double calcularArea()
        {
            double lado = (this.diagonal / Math.Sqrt(2));
            return (lado*lado);
        }
    }
}

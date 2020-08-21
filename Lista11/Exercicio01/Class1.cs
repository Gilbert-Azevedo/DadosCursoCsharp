using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Circulo
    {
        public double r,area,circunf;
        public double CalcAreaCirculo()
        {
            area = Math.PI * r * r;
            return area;
        }
        public double CalcCircunfCirculo()
        {
            circunf = 2*Math.PI * r;
            return circunf;
        }
    }
}

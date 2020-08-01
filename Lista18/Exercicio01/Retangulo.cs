using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Retangulo
    {
        private double b, h;
        public Retangulo(double b, double h)
        {
            if (b > 0) this.b = b;
            if (h > 0) this.h = h;
        }
        public double Base { get => b; set => b = value > 0 ? value : 0; }
        public double Altura { get => h; set => h = value > 0 ? value : 0; }
        public double Area { get => b*h;}
        public double Diagonal { get => Math.Sqrt(b*b + h*h);}

      /* public override string ToString()
       {
           return $" {Base} | Altura = {Altura}";
       }*/



    }
}

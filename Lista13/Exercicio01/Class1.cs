using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Retangulo
    {
        private double b,h;
        public Retangulo(double b, double h) {
            if (b > 0) this.b = b;
            if (h > 0) this.h = h;
            }
        public void SetBase(double b)
        {
            if (b > 0) this.b = b;
        }
        public void SetAltura(double h)
        {
            if (h > 0) this.h = h;
        }

        public double GetBase(double b)
        {
            return this.b;
        }
        public double GetAlgura(double h)
        {
            return this.b;
        }

        public double CalcArea()
        {
            double area = b * h;
            return area;
        }
        public double CalcDiagonal()
        {
            double diagonal = Math.Sqrt(b*b+h*h);
            return diagonal;
        }
        public override string ToString()
        {
            return $"Base = {b}  - Altura = {h}";
        }

    }
}

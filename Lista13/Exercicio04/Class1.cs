using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Equacao
    {
        private double a, b, c;

        public Equacao(double a, double b, double c)
        {
            if (a != 0) { this.a = a; }
             this.b = b;
             this.c = c;

        }
        public void SetABC(double  a, double  b, double c)
        {
            if (a != 0) this.a = a;
            this.b = b;
            this.c = c;

        }
        public void GetABC(out double a, out double b, out double c) 
        {
            a = this.a;
            b = this.b;
            c = this.c;
        }

        public double Delta()
        {
            double delta = (b*b)-(4*a*c);
            return delta;
        }

        public bool RaizesReais(out double x1, out double x2)
        {
            double x11 = 0, x12 = 0;
            bool possuiraizes = false;

            if (Delta() >= 0)
            {
                possuiraizes = true;

                if (possuiraizes)
                {
                    x11 = (-b + Math.Sqrt(Delta())) / (2 * a);
                    x12 = (-b - Math.Sqrt(Delta())) / (2 * a);
                }
                
            }
            x1 = x11;
            x2 = x12;
            return possuiraizes;
        }
        public override string ToString()
        {
            double x1 = 0;
            double x2 = 0;

            if (RaizesReais(out x1, out x2))
            {
                double xa = x1;
                double xb = x2;

                return $" As Raízes reais da equação de 2° Grau são: x1 = {xa:0.00} e {xb:0.00} ";
            }
            else
            {
                return " Não possui raizes Reais";
            }

        }



    }
}

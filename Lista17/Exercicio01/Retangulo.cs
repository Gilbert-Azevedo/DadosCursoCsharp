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


        public double Base
        {
            get { return b; }
            set { if (value > 0) b = value; }
        }
        public double Altura
        {
            get { return h; }
            set { if (value > 0) h = value; }
        }
        public double Area { 
        get{ return b * h; }
        
        }
    public double Diagonal {
            get { return Math.Sqrt(b * b + h * h); }
        }

        public override string ToString()
        {
            return $" Base = {Base:0.00} - Altura = {Altura:0.00}  - Area = {Area:0.00} - Diagonal = {Diagonal:0.00}" ;
        }

    }
}

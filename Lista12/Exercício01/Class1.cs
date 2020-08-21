using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício01
{
    class Circulo
    {
        private double r;
        public void SetRaio(double v) {
            if (v > 0) r = v; }

        public double GetRaio() { 
            return r;}
        public double CalcArea()
        {
            double area = Math.PI * r * r;
            return area;
        }
        public double CalcCircunferencia()
        {
            double circunferencia = 2*Math.PI * r;
            return circunferencia;
        }


    }
}

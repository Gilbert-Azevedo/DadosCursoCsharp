using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Frete
    {
        private double distancia, peso;
        public Frete(double d, double p)
        {
            if (d > 0) distancia = d;
            if (p > 0) peso = p;
        }
        public double Distancia { get; set; }
        public double Peso { get; set; }
        public double CalculaFrete {get { return Distancia * Peso * 0.01; } }
    }

  //  public override string ToString()
   // {
   //     return $" Distancia = {distancia} | Peso = {peso} ";
   // }

}

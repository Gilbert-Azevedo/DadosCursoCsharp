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
        public void SetDistancia(double d)
        {
            if (d > 0) distancia = d;
        }
        public void SetPeso(double p)
        {
            if (p > 0) peso = p;
        }

        public double GetDistancia()
        {
            return distancia;
        }
        public double GetPeso()
        {
            return peso;
        }

        public double CalcFrete()

        {
            double valorfrete = 0.1 * peso * distancia;

            return valorfrete;
        }

        public override string ToString()
        {
            return $" Peso da carga =  {peso:0.00} kg -   Distância percorrida  {distancia:0.00} Km";

        }


    }

}

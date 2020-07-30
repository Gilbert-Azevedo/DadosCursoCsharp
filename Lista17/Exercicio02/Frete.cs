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
        public double Distancia {
            get { return distancia; }
            set { if (value >= 0) distancia = value; }
                    }
        public double Peso
        {

            get { return peso; }
            set { if (value > 0) peso = value; }
        }

        public double ValorFrete
        {
            get { return distancia*peso*0.01; }
         }


        public override string ToString()
        {
            return $" Distancia = {Distancia} | Peso = {Peso}  | Frete = {ValorFrete}";
        }

    }




    
}

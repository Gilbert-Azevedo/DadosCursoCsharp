using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Viagem
    {
        private double distancia;
        private double tempo;
        public void SetDistancia(double d)
        {
            if (d > 0) distancia = d;
        }
        public void SetTempo(double t)
        {
            if (t > 0) tempo = t;
        }

        public double GetDistancia()
        {
            return distancia;
        }
        public double GetTempo()
        {
            return tempo;
        }
        public double VelocidadeMedia()
        {
         double  velocidade = distancia / tempo;
            return velocidade;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    public class Viagem
    {
        public double dist,veloc;
        public double horas,min;

        public double Velocidade()
        {
            horas = horas + (min / 60);
            veloc = dist / horas;
            return veloc;

        }


    }
}

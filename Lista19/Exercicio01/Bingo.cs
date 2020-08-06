using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Bingo
    {
        private int numBolas;
        private int k;

        public int NumBolas {
            get{return numBolas;}
            set{if(value > 0) numBolas = value; } 
        }
        public void Iniciar(int numBolas)
        {
            NumBolas = numBolas;
        }
        public int Proximo()
        {
            int proximo;
            Random numAleatorio = new Random();
            
            if (k < numBolas)
            {
                proximo = numAleatorio.Next(1, NumBolas);
            }
            else
            { 
            proximo = -1;
            }

            return proximo;
        }
        public int[] Sorteados()
        {
            int[] numSorteados = new int[k+1];
            if (k < NumBolas) numSorteados[k++] = Proximo();

            return numSorteados;
        }

    }

}

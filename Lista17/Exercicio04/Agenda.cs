using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Agenda
    {
        private Compromisso[] comps;
        private int k;

        
        }
        public int Qtd
        {
        get { return quant; }
        }

    public void Inserir(Compromisso c)
        {
           comps = new Compromisso[k+1];
            if (k<Qtd)
            {
                comps[k] = c;
                k++;
            }


    



    }
}

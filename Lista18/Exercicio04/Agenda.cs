using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Agenda
    {
        private Compromisso[] comps = new Compromisso[10];
        private int k;

        public int Qtd { get { return k; } }


        public void Inserir(Compromisso c)
        {
            if (k > 9) 
            Array.Resize(ref comps, 2 * comps.Length);
            
              comps[k++] = c;
            
        }

        public void Excluir(Compromisso c)
        {
            int i = 0;
            int j = 0;
            while ((comps[i] != c) && (i < comps.Length)) i++;
            comps[i] = null;
            for (j = i; j < k; j++)
                comps[j] = comps[j + 1];

            Array.Resize(ref comps, comps.Length - 1);
            k--;
        }

        public Compromisso[] Listar()
        {
            Compromisso[] novoscomps = new Compromisso[k];

            Array.Copy(comps, novoscomps, k);

            return novoscomps;

        }

        public Compromisso[] Pesquisar(int mes, int ano)
        {
            int ncomp = 0;

            for (int i = 0; i < Qtd; i++)
            {
                if ((comps[i].Data.Month == mes) && (comps[i].Data.Year == ano)) ncomp++;
            }

            int cont = 0;

            Compromisso[] listapesquisa = new Compromisso[ncomp];

            for (int i = 0; i < Qtd; i++)
            {
                if ((comps[i].Data.Month == mes) && (comps[i].Data.Year == ano))
                {
                    listapesquisa[cont++] = comps[i];
                }
            }
            return listapesquisa;

        }


    }
}

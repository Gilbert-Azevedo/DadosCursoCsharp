using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Agenda
    {
        private Contato[] contatos;
        private int numconts, mesaniv, k = 0;
  
        public Agenda(int num)
        {
            if (num >= 0) numconts = num;
            contatos = new Contato[numconts];
        }

        public int GetNumContatos()
        {
            return numconts;
        }


        public void inserir(Contato contat)
        {
            if (k < GetNumContatos())
                contatos[k] = contat;
            k++;
        }

        public Contato[] Listar()
        {
            Contato[] listacontatos = new Contato[k];
            Array.Copy(contatos, listacontatos, k);
            return listacontatos;
        }

        public Contato[] AniversariantesMes(int mes)
        {
            Contato[] listaaniversariante = new Contato[k+1];
            int contaniv = 0;
            for (int i = 0; i < GetNumContatos(); i++)
            {
                DateTime datanasc = contatos[i].GetNascimento();
                mesaniv = datanasc.Month;
                if (mesaniv == mes) contaniv++;
            }
            k = 0;
            for (int i = 0; i < GetNumContatos(); i++)
            {
                DateTime datanasc = contatos[i].GetNascimento();
                mesaniv = datanasc.Month;

                if (mesaniv == mes) 
                {
                    listaaniversariante[k] = contatos[i];
                    k++;
                }

            }
            return  listaaniversariante;
        }
       

    }
}

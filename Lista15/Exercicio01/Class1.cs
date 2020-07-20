using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercicio01
{
    class Colecao
    {
        private object[] itens;
        private int max;

        public Colecao(int max)
        {
            if (max >= 0) this.max = max;
            itens = new object[max];
         }
        
        public void Inserir(object item)

        {
            int i = NumItens();
            itens[i] = item;
        }

        public object[] Listar()
        {
            return itens;
        }



        public int NumItens()
        {
            int num = 0;
            for (int i = 0; i < max; i++)
                if (itens[i] != null)
                {
                    num++;
                }
                        
            
            return num;
        }

    }

    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Conversor
    {
        private int num;
        public Conversor(int num)
        {
            if (num > 0) this.num = num;
        }

        public void SetNum(int num)
        {
           if (num > 0) this.num = num;
        }
        public int GetNum()
        {
           return this.num;
        }
        public string Binario()
        {
            int divnum = num;
            string numbinario=null;

            while (divnum >= 1)
            {
                numbinario += Convert.ToString(divnum % 2);
                divnum = divnum / 2;
            }

       

            return numbinario;
                      
        }
        public override string ToString()
        {
            return $" o número inteiro {num} na base binária é: {Binario()} ";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Conta
    {
        public string nome, numero;
        public decimal saldo=0,depos=0,saque=0;

        public decimal depositar()
        {
            saldo = saldo + depos;
            return saldo;
            
        }
        public decimal sacar()
        {
            saldo = saldo - saque;
            return saldo;

        }
    }
}

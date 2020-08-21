using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Conta
    {
        private string nomecliente, numeroconta;
        private decimal saldo,deposito,saque;

        public void SetNome(string n)
        {
            if (n != null) nomecliente = n;
        }
        public void SetNumeroConta(string nc)
        {
            if (nc != null) numeroconta = nc;
        }

        public void SetSaldo(decimal sa)
        {
            if (sa > 0) saldo = sa;
        }
        public void SetDeposito(decimal d)
        {
            if (d > 0) deposito = d;
        }
        public void SetSaque(decimal sq)
        {
            if (sq > 0) saque = sq;
        }
        

        public string GetNome()
        {
            return nomecliente;
        }

        public string GetNumeroConta()
        {
            return numeroconta;
        }
        public decimal GetSaldo()
        {
            return saldo;
        }
        public decimal GetDeposito()
        {
            return deposito;
        }
        public decimal GetSaque()
        {
            return saque;
        }

        public decimal Deposito()
        {
            saldo = saldo + deposito;
            return saldo;
        }
       
        public decimal Saque()
        {
            saldo = saldo - saque;
            return saldo;
        }


    }
}

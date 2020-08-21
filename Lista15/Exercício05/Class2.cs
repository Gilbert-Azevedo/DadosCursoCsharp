using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Exercício05
{
    class Cliente
    {
        private string nome, cpf;
        private decimal limite;
        private Cliente socio;

        public Cliente(string nome, string cpf, decimal limite)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.limite = limite;
        }

        public void SetSocio(Cliente c)
        {
            socio = c;
            c.socio=this;

         }

        public Cliente GetSocio()
        {
            return socio;

        }



        public decimal GetLimite()
        {
           decimal limitesociedade = limite + socio.limite;
         return limitesociedade;

        }
        public override string ToString()
        {
            return $" Nome: {nome} | CPF:{cpf} | Limite: {GetLimite()}  | Socio: {GetSocio().nome}  ";
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Contato
    {
        private string nome, telefone;
        private DateTime nascimento=new DateTime();

        public Contato(string n,string t, DateTime nasc)
        {

            nome = n;
            telefone = t;
            nascimento = nasc;

        }

        public string GetNome()
        {
            return nome;
        }

        public string GetTelefone()
        {
            return telefone;
        }

        public DateTime GetNascimento()
        {
            return nascimento;
        }

        public override string ToString()
        {
            return $"Nome: {GetNome()}  - Telefone: {GetTelefone()} -  Data de Nascimento: {GetNascimento():dd/MM/yyyy}";
        }

    }
}

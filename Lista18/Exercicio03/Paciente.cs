using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Paciente
    {
        private string nome, cpf, telefone;
        private DateTime nascimento;
        public Paciente(string n, string c, string t, DateTime d)
        {
            if (n != null) nome = n;
            if (c != null) cpf = c;
            if (t != null) telefone = t;
            nascimento = d;
        }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public DateTime Nascimento { get; set; }

        public string Idade
        {
            get => ((DateTime.Now - Nascimento).Days/365).ToString();
        }
        public override string ToString()
        {
            return $" {Nome} | CPF: {Cpf} | Tel:  {Telefone} | Nasc:  {Nascimento:dd/MM/yyyy}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exercicio01
{
    class Paciente
    {
        private string nome, cpf, telefone;
        private DateTime nascimento = new DateTime();
        public Paciente(string n, string c, string t, DateTime nasc)
        {
            if (n != null) nome = n;
            if (c != null) cpf = c;
            if (t != null) telefone = t;
            nascimento = nasc;      // Verificar qual o teste a ser feito!
        }

        public string Idade()
        {
            DateTime hoje = DateTime.Today;
            TimeSpan id = (hoje.Subtract(nascimento));
            int idadetotal = int.Parse(id.Days.ToString());
            int anos = idadetotal / 365;
            int dias = idadetotal % 365;
            int meses = dias / 30;

            string idade = $" {anos} anos e {meses} meses ";
            return idade;
        }
             

        public override string ToString()
        {
            return $"{nome} - CPF:{cpf} - Telefone : {telefone}  - Data de Nascimento: {nascimento} - {Idade()} ";
        }

    }
}

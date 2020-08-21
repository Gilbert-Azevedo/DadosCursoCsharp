using System;

namespace Exercicio03
{
    class Paciente
    {
        private string nome, cpf, telefone;
        private DateTime nascimento;

        public Paciente(String n, string c, string t, DateTime d)
        {
            if (n != null) nome = n;
            if (c != null) cpf = c;
            if (t != null) telefone = t;
             nascimento = d;
        }

        /*public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Telefone { get; set; }

        public DateTime Nascimento { get; set; }*/

        public string Nome {
            get { return nome; }
            set { nome = value; }

        }

        public string Cpf {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Telefone {
            get { return telefone; }
            set { telefone = value; }
        }
        
        public DateTime Nascimento {

            get { return nascimento; }
            set { nascimento = value; }
        }

        public TimeSpan Idade
        {
            get { return DateTime.Now - nascimento; }  // Vrificar como desmembrar!
        }

        public override string ToString()
        {
            return $" Dados do paciente : Nome : {Nome}   |   CPF:   {Cpf}   |   Telefone: {Telefone}  |  Idade : {Idade} ";
        }






    }

}

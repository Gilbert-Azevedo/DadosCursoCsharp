using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Cliente
    {
        public string Nome { get { return nome; } }
        public string Cpf { get { return cpf; } }
        public decimal LimitePessoal { get { return limite; } }
        public string Socio { get { if (socio == null) return ""; else return socio.nome; } }
        public decimal LimiteTotal { get { return GetLimite(); } }


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
            Cliente a = null;
            Cliente b = null;
            if (this.socio != null) a = this.socio;
            if (c.socio != null) b = c.socio;
            if (a != null) a.socio = null;
            if (b != null) b.socio = null;

            this.socio = c;
            c.socio = this;

        }

        public Cliente GetSocio()
        {
            return socio;

        }


        public decimal GetLimite()
        {
            if (socio == null)
                return limite;
            else
                return limite + socio.limite;
        }

    }
}

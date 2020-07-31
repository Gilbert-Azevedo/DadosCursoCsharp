using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Aplicativo
    {
        private int curtidas;
        private string nome, categoria;
        private decimal preco;
        public Aplicativo(string n, string c, decimal p)
        {
            if (n != null) nome = n;
            if (c != null) categoria = c;
            if (p >= 0) preco = p;

        }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Preco { get; set; }
        public int Curtidas { get { return curtidas; } }

        public void Curtir()
        {
            curtidas++;
        }

        public override string ToString()
        {
            return $" Nome do aplicativo {Nome}  | Categoria:  {Categoria} |  Preço:  {Preco}" ;
        }




    }
}

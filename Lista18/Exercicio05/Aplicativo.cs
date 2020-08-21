using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Aplicativo
    {
        
       private int curtidas;

     
     
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
            return $" Nome do app:  {Nome} | Cat:  {Categoria} |  Preço:  {Preco} | Curtidas: {Curtidas}";
        }

    }
}

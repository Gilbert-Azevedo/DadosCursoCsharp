using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Loja
    {
        private Aplicativo[] apps = new Aplicativo[1];
        private int k;
        public string Nome {{ get; set; } }
        public int Qtd {{ get; set; } }



        public void Inserir(Aplicativo app)
        {
            Aplicativo novo = new Aplicativo(Nome,Categoria,Preco);
                   
        }

    }
}

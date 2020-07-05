using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Produto
    {
        private string descricao;
        private decimal valor;
        public Produto(string d, decimal v)
        {
            if (d != null) descricao = d;
            if (v >= 0) valor = v;
        }

        public override string ToString()
        {
            return $" Descrição do produto:  {descricao}         - Valor do produto: {valor:0.00}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class ValeCompras
    {
        private DateTime dataValidade = new DateTime();
        private decimal valor;

        public ValeCompras(DateTime d, decimal v)
        {
            dataValidade = d;
            if (v >= 0) valor = v;
        }

        public override string ToString()
        {
            return $" Data de Validade para troca: {dataValidade}  - Valor do Vale compras: {valor:0.00} Reais";
        }




    }
}

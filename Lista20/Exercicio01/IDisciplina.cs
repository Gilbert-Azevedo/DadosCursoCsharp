using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    interface IDisciplina
    {
        public string GetNome() { return nome;}
        public int CalcMediaParcial();
        public int CalcMediaFinal();

    }
}

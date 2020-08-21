using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    interface IDisciplina
    {
        string GetNome();
        int CalcMediaParcial();
        int CalcMediaFinal();
    }
}
